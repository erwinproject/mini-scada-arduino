/* ======================================================================
                   PROGRAM NODEMCU MIKROKONTROLER BEBAN [NOT TESTED]
   ======================================================================
   >> ERWIN NUR CAHYONO | Email : erwinproject.id@gmail.com
   Rebuild       : 17-06-2019
   FITUR PROGRAM :
   [+] TOKEN AUTH
   [+] SEND LOAD DATA TO SERVER
   [+] GET DATA FROM SERVER
   [+] MULTI PARSING DATA
   [+] GET DATA PROTECTION
   [+] PROTEKSI RELAY
   [+] SEND STATUS RELAY TO SERVER
   ======================================================================
*/
#include <SoftwareSerial.h>
#include <ESP8266WiFi.h>
#include <ArduinoJson.h>

#define br        57600  // my baudrate
#define rx1       D3
#define tx1       D4
#define relay     D5
#define ON        LOW
#define OFF       HIGH

SoftwareSerial fromUno (rx1, tx1);

// CONFIG WIFI & SERVER
const char* ssid     = "prenata";
const char* password = "prenata123";
//const char* ssid       = "erwinproject";
//const char* password   = "erwinnc1997";
//const char* ssid     = "NURSALIM";
//const char* password = "Apriskasury";
//const char* host     = "scada.erwinproject.net";
const char* host       = "167.71.214.209";
//const char* host     = "192.168.1.100/ta";
const int   httpPort   = 80;
const char* token      = "07d95caa0305eef83b47ec1fb6ccf69a";

// ========= CRUD MODE =========
String url;
String apiInsertDb = "/api/update/load.php?";               // LINK INSERT TO DB
String apiGetConfig = "/api/get/config_load.php?";          // LINK GET SET PROTEKSI IN DB

String Srelay = "Idle";

String conf_tegangan, conf_arus, conf_statusalat;
String control = "On";

// DATA INSERT TO SERVER
String varToken = "token=";
String varTegangan = "&tegangan=";
String varArus = "&arus=";
String varDaya = "&daya=";
String varRelay = "&relay=";

// Data parsing
int i;
String dt[100];
double data_arus, data_tegangan, data_daya;
String data_relay;
String GetData;

// Send data to Arduino
String SendData;
String pemisah = "|";


void setup() {
  pinMode(relay, OUTPUT);
  Serial.begin(br);
  fromUno.begin(br);
  ConWifiku();
}

void loop() {
  KomFromUno();
  if (GetData.length() > 0) {
    parsingData();
    sendtoServer();
    delay(200);
  }
  GetData = "";
  getConf_server();
  relayprog();
  delay(1000);
}

void relayprog() {
  if ((data_tegangan >= conf_tegangan.toFloat()) || (data_arus > conf_arus.toFloat()) || control == "Off")  {
    digitalWrite(relay, ON);
    Srelay = "Active";
  }
  else if (((data_tegangan >= conf_tegangan.toFloat()) || (data_arus > conf_arus.toFloat())) && (control == "Off")) {
    digitalWrite(relay, ON);
    Srelay = "Active";
  }
  else {
    digitalWrite(relay, OFF);
    Srelay = "Idle";
  };
}

void urlUpdate() {
  url = apiInsertDb;
  url += varToken;
  url += token;
  url += varTegangan;
  url += data_tegangan;
  url += varArus;
  url += data_arus;
  url += varDaya;
  url += data_daya;
  url += varRelay;
  url += Srelay;
}

void urlGetConfig() {
  url = apiGetConfig;
  url += varToken;
  url += token;
}

// SEND DATA TO SERVER
void sendtoServer() {
  WiFiClient client;
  if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    ConWifiku();

    return;
  }
  urlUpdate();                   // INSERT URL
  Serial.println();
  Serial.print("Requesting URL: ");
  Serial.println(url);

  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" +
               "Connection: close\r\n\r\n");
  delay(500);
  while (client.available()) {
    String line = client.readStringUntil('\r');
    Serial.print(line);
  }
  delay(250);
}

// GET DATA CONFIG DARI SERVER
void getConf_server() {
  WiFiClient client;
  if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    //ConWifiku();
    return;
  }
  urlGetConfig();
  //Serial.print("Requesting URL: ");
  //Serial.println(url);

  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" +
               "Connection: close\r\n\r\n");
  delay(500);

  String section = "header";
  while (client.available()) {
    String line = client.readStringUntil('\r');
    //Serial.print(line);
    if (section == "header") {

      if (line == "\n") {
        section = "json";
      }
    }
    else if (section == "json") {
      section = "ignore";
      String result = line.substring(1);

      // Parse JSON
      int size = result.length() + 1;
      char json[size];
      result.toCharArray(json, size);
      StaticJsonBuffer<200> jsonBuffer;
      JsonObject& json_parsed = jsonBuffer.parseObject(json);
      if (!json_parsed.success())
      {
        Serial.println("parseObject() failed");
        return;
      }
      String teganganPB1 = json_parsed["dataconfig"][0]["tegangan"];
      String arusPB1 = json_parsed["dataconfig"][0]["arus"];
      String statusAlatServer = json_parsed["dataconfig"][0]["statusalat"];
      
      conf_tegangan = teganganPB1;
      conf_arus = arusPB1;
      conf_statusalat = statusAlatServer;
      print_conf_server();
      
      control = conf_statusalat;
      
      
      delay(100);
    }
  }
}

void print_conf_server() {
  Serial.println();
  Serial.println("============ CONFIG LOAD SERVER ============");
  Serial.print(conf_tegangan);
  Serial.print(" | ");
  Serial.print(conf_arus);
  Serial.print(" | ");
  Serial.print(conf_statusalat);
  Serial.println();
}

// PARSING DATA DARI ARDUINO
void parsingData() {
  int j = 0;
  dt[j] = "";
  for (i = 1; i < GetData.length(); i++) {
    if ((GetData[i] == '|'))
    {
      j++;
      dt[j] = "";
    }
    else
    {
      dt[j] = dt[j] + GetData[i];
    }
  }
  data_tegangan = (dt[0].toFloat());
  data_arus = (dt[1].toFloat());
  data_daya = (dt[2].toFloat());

  show_print_arduino();
  
}

void show_print_arduino() {
  Serial.println();
  Serial.println("============ NEW DATA ARDUINO ============");
  Serial.print(data_tegangan);
  Serial.print(" | ");
  Serial.print(data_arus);
  Serial.print(" | ");
  Serial.print(data_daya);
  Serial.println();
}

// GET DATA DARI ARDUINO
void KomFromUno() {
  while (fromUno.available()) {
    delay(10);
    char v = fromUno.read();
    GetData += v;
  }
}

// MENYAMBUNG KONEKSI WIFI
void ConWifiku() {
  Serial.print("Mengkoneksikan ke ");
  Serial.println(ssid);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("Terkoneksi wifi");
  Serial.println("Alamat IP: ");
  Serial.println(WiFi.localIP());
  Serial.print("Netmask: ");
  Serial.println(WiFi.subnetMask());
  Serial.print("Gateway: ");
  Serial.println(WiFi.gatewayIP());

}
