/* ======================================================================
                   PROGRAM NODEMCU MIKROKONTROLER PANEL
   ======================================================================
   >> ERWIN NUR CAHYONO | Email : erwinproject.id@gmail.com
   REBUILD       : 16-06-2019
   FITUR PROGRAM :
   [+] AUTH TOKEN
   [+] SEND DATA TO SERVER
   [+] GET DATA FROM SERVER
   [+] MULTI PARSING DATA
   ======================================================================
*/
#include <SoftwareSerial.h>
#include <ESP8266WiFi.h>
#include <ArduinoJson.h>

#define br        57600  // my baudrate
#define rx1       D5
#define tx1       D6
#define rx2       D3
#define tx2       D4
//#define ledInd    D7

SoftwareSerial fromUno (rx1, tx1);
SoftwareSerial sendUno (rx2, tx2);

// CONFIG WIFI & SERVER
const char* ssid     = "prenata";
const char* password = "prenata123";
//const char* ssid     = "erwinproject";
//const char* password = "erwinnc1997";
//const char* ssid     = "NURSALIM";
//const char* password = "Apriskasury";
//const char* host     = "scada.erwinproject.net";
const char* host     = "167.71.214.209";
const int   httpPort = 80;

const char* token = "07d95caa0305eef83b47ec1fb6ccf69a";

// ========= CRUD MODE =========
String url;
String apiGetdata_SC = "/api/get/config_panel.php?";  // API GET DATA PROTEKSI SC
String apiInsertDb = "/api/update/solarpanel.php?";      // API INSERT DATA

// var to send server
String varToken = "token=";
String varRTC = "&date=";
String varTegangan = "&tegangan=";
String varArus = "&arus=";
String varDaya = "&daya=";
String varSAlat = "&status=";
String varSRelay = "&relay=";
String varPersenAki = "&persen=";

// var to get data server
String RTC, data_tegangan, data_arus, data_daya, data_SAlat, data_SRelay, data_PersenAki;

// data parsing
int i;
String dt[100];
String data_set_tegangan, data_set_arus, data_set_control, data_set_settimea, data_set_settimeb;

// Send data to Arduino
String SendData;
String pemisah = "|";

String GetData;
boolean sendkun = false;

void setup() {
  Serial.begin(br);
  fromUno.begin(br);
  sendUno.begin(br);
  ConWifiku();
}

void loop() {
  getConfig_panel();
  sendToUno();

  KomFromUno();
  //Serial.println(GetData);
  if (GetData.length() > 0) {
    parsingData();
    sendtoServer();
  }
  GetData = "";
  delay(500);


  //  if (sendkun == false) {
  //    getConfig_panel();
  //    sendToUno();
  //
  //    sendkun = true;
  //  }
  //  if (sendkun == true) {
  //    KomFromUno();
  //    //Serial.println(GetData);
  //    if (GetData.length() > 0) {
  //      parsingData();
  //      sendtoServer();
  //      delay(500);
  //    }
  //    GetData = "";
  //    sendkun = false;
  //  }
}

// Set URL Insert Data to Server
void modeinsert() {
  url = apiInsertDb;
  url += varToken;
  url += token;
  url += varRTC;
  url += RTC;
  url += varTegangan;
  url += data_tegangan;
  url += varArus;
  url += data_arus;
  url += varDaya;
  url += data_daya;
  url += varSAlat;
  url += data_SAlat;
  url += varSRelay;
  url += data_SRelay;
  url += varPersenAki;
  url += data_PersenAki;
}

// Send Data to Server
void sendtoServer() {
  WiFiClient client;
  if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    ConWifiku();
    //sendtoServer();
    return;
  }
  modeinsert();
  Serial.print("Requesting URL: ");
  Serial.println(url);

  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" +
               "Connection: close\r\n\r\n");
  delay(100);
  while (client.available()) {
    String line = client.readStringUntil('\r');
    Serial.print(line);
  }
  delay(100);
}

// PARSING DATA DARI ARDINO KE NODEMCU
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
  RTC = (dt[0]);
  data_tegangan = (dt[1]);
  data_arus = (dt[2]);
  data_daya = (dt[3]);
  data_SAlat = (dt[4]);
  data_SRelay = (dt[5]);
  data_PersenAki = (dt[6]);

  showprint_data_arduino();

}

// SHOW PRINT DATA DARI ARDUINO
void showprint_data_arduino() {
  Serial.println();
  Serial.println("============ NEW DATA ARDUINO ============");
  Serial.print(RTC);
  Serial.print(" | ");
  Serial.print(data_tegangan);
  Serial.print(" | ");
  Serial.print(data_arus);
  Serial.print(" | ");
  Serial.print(data_daya);
  Serial.print(" | ");
  Serial.print(data_SAlat);
  Serial.print(" | ");
  Serial.print(data_SRelay);
  Serial.print(" | ");
  Serial.print(data_PersenAki);
  Serial.println();
}

// SET URL TO GET DATA SERVER
void get_data_server() {
  url = apiGetdata_SC;
  url += varToken;
  url += token;
}

// AMBIL DATA DARI SERVER
void getConfig_panel() {
  WiFiClient client;
  if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    ConWifiku();

    return;
  }
  get_data_server();

  Serial.print("Requesting URL: ");
  Serial.println(url);

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
      String server_tegangan = json_parsed["dataconfig"][0]["tegangan"];
      String server_arus = json_parsed["dataconfig"][0]["arus"];
      String server_control = json_parsed["dataconfig"][0]["control"];
      String server_jamawal = json_parsed["dataconfig"][0]["settimea"];
      String server_jamakhir = json_parsed["dataconfig"][0]["settimeb"];

      data_set_tegangan = server_tegangan;
      data_set_arus = server_arus;
      data_set_control = server_control;
      data_set_settimea = server_jamawal;
      data_set_settimeb = server_jamakhir;

      delay(100);
      showprint_data_server();
    }
  }
}

// SHOW PRINT DATA DARI SERVER
void showprint_data_server() {
  Serial.println();
  Serial.println("============ NEW DATA SERVER ============");
  Serial.print(data_set_tegangan);
  Serial.print(" | ");
  Serial.print(data_set_arus);
  Serial.print(" | ");
  Serial.print(data_set_control);
  Serial.print(" | ");
  Serial.print(data_set_settimea);
  Serial.print(" | ");
  Serial.print(data_set_settimeb);
  Serial.println();
}

// SEND DATA TO ARDUINO UNO
void sendToUno() {
  SendData = pemisah + data_set_tegangan + pemisah + data_set_arus + pemisah + data_set_control + pemisah + data_set_settimea + pemisah + data_set_settimeb;
  if (SendData.length() > 0) {
    sendUno.print(SendData);

    Serial.println();
    Serial.print("Send Data : ");
    Serial.println(SendData);
  }
  delay(100);
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

// KOMUNIKASI RX TX DARI ARDUINO
void KomFromUno() {
  while (fromUno.available()) {
    delay(10);
    char v = fromUno.read();
    GetData += v;
  }
}
