/* ======================================================================
                      PROGRAM MIKROKONTROLER PANEL
   ======================================================================
   ERWIN NUR CAHYONO | erwinproject.id@gmail.com
   PROGRAM FITURE :
   [+] RTC DS3231
   [+] 1 DC CURRENT MEASUREMENT ACS712
   [+] 1 DC VOLTAGE MEASUREMENT
   [+] CALCULATION POWER MEASURMENT (WATT)
   [+] RELAY AUTO CHARGING
   [+] SEND DATA TO NODEMCU V3
   ======================================================================
*/
#include <DS3231.h>
#include <SoftwareSerial.h>
#include <Wire.h>

const int pinV1 = A0;
//#define pinV1         A0  // SENSOR TEGANGAN SOLAR CELL
#define pinA1         A2  // SENSOR ARUS PADA PWM CHARGE
#define Sda           A4  // SDA I2C
#define Scl           A5  // SCL I2C
#define MyRelay       3   // RELAY JAM
#define MyRelay2      4   // PROTEKSI
#define RHigh         LOW
#define RLow          HIGH
#define rx1           9   // KOMUNIKASI KE NODEMCU
#define tx1           10
#define rx2           11  // KOMUNIKASI DARI NODEMCU KE ARDUINO
#define tx2           12
#define br            57600

SoftwareSerial ToNode (rx1, tx1);
SoftwareSerial FromNode (rx2, tx2);
Time t;
DS3231 rtc(Sda, Scl); // inisialisasi penggunaan i2c

// GLOBAL CONFIG
int con_time = 1000;

float val2;

// SENSOR ACS712
const int analogIn  = pinA1;
// use 100 for 20A Module and 66 for 30A Module
int mVperAmp = 100; // DEFAULT 185
int RawValue = 0;
int ACSoffset = 2500;

double Voltage = 0;
double Amps = 0;
double ampereku = 0;

// SENSOR TEGANGAN SOLARCELL
float fixdataTegangan1 = 0;
float vOUT = 0.0;
float vIN = 0.0;
float R1 = 30000.0;
float R2 = 7500.0;
int   value = 0;

float CMPCharge = 0.4;
float CMPNCharge = 0.2;

float CMP12 = CMPNCharge;        // USB LAPTOP 0.6 - SUPPLY SOLAR CHARGE 0.9 / NO CHARGE 0.7
float BatasMaxAki = 14.5;
float autocharge = 10;           // CHARGE AGAIN IN %
float BatasMinAki = 11.8;
double persen_aki;

// DAYA
float watt;

// RELAY SETTING
int DRelay = 3;
int DRelayCharge;

// STATUS PROTEKSI
String ProteksiRelay = "Idle";

// DELAY SEND TO NODEMCU
float aturdelay = 15;    // menit
long int perms = 1000, convertminutes = 60;
long int hasildelay;

// NOTIFIKASI POSISI CHARGING RTC
uint8_t GetHour = 0;
int jamawalcharge = 10;
int jamakhircharge = 16;
String ChargeAki, DateRTC, TanggalRTC, TimeRTC;

String StatusAlat = "On";
int count_proteksi;
// GET DATA
int i;
String dt[10];

float dataset_tegangan = 14.6, dataset_arus = 2500;
String dataset_control;
int dataset_timea, dataset_timeb;

int b = 0;
String GetData = "", SendData = "", pemisah = "|";

boolean sendkun = false;
boolean battraifull = false;

// ==========================================================================
void setup() {
  pinMode(pinV1, INPUT);
  pinMode(pinA1, INPUT);
  pinMode(MyRelay, OUTPUT);
  pinMode(MyRelay2, OUTPUT);

  digitalWrite(MyRelay, RLow);
  digitalWrite(MyRelay2, RLow);

  Serial.begin(br);
  ToNode.begin(br);
  FromNode.begin(br);
  rtc.begin();
  Serial.println(" System Will be Start in 5 Seconds . . ");
  delay(5000);
}

// ==========================================================================

void loop() {
  ProgRTC();
  KomFromNode();
  if (GetData.length() > 0) {
    parsingData();
  }
  GetData = "";


  proteksiAki();
  pArus1();           // PROGRAM SENSOR ARUS ACS712
  rtegangan1();       // PROGRAM SENSOR TEGANGAN SOLAR CELL
  wattmeter();        // PROGRAM KALKULASI WATT / DAYA
  kalkulasibattrai(); // PROGRAM BACA STATUS AKI %

  sendNode();         // MENGIRIM DATA KE NODEMCU
  KomToNode();        // KIRIM UART SERIAL

  //  Serial.println(ampereku);

  // OLD PROGRAM
  //    if (sendkun == false) {
  //      KomFromNode();
  //      if (GetData.length() > 0) {
  //        parsingData();
  //      }
  //      GetData = "";
  //      sendkun = true;
  //    }
  //    if (sendkun == true) {
  //      pArus1();           // PROGRAM SENSOR ARUS ACS712
  //      rtegangan1();       // PROGRAM SENSOR TEGANGAN SOLAR CELL
  //      wattmeter();        // PROGRAM KALKULASI WATT / DAYA
  //      kalkulasibattrai(); // PROGRAM BACA STATUS AKI %
  //
  //      KomToNode();        // PROGRAM BACA DATA SERIAL
  //      sendNode();         // MENGIRIM DATA KE NODEMCU
  //      sendkun = false;
  //      //delay(1000);
  //    }

  delay(1000);
}
// ==========================================================================

// ============== MY SUB FUNCTION ==============
// READ SEND DATA TO NODEMCU
void KomToNode() {
  while (ToNode.available()) {
    delay(10);
    char c = ToNode.read();
    SendData += c;
  }
}

void kalkulasibattrai() {
  if (ChargeAki == "Not%20Charging") {
    //    BatasMaxAki = 13.1;
    BatasMaxAki = 13.3;
  } else {
    BatasMaxAki = 14.5;
  };
  double selisih_data = (fixdataTegangan1 - BatasMinAki);
  persen_aki = (100 / (BatasMaxAki - BatasMinAki) * selisih_data);
  if (persen_aki >= 100) {
    persen_aki = 100;
  }
  else if (persen_aki <= 0) {
    persen_aki = 0;
  };
  if (persen_aki == 100) {
    battraifull = true;
  }
  else if (persen_aki < autocharge ) {
    battraifull = false;
  }

}


void sendNode() {
  SendData = pemisah;
  SendData += DateRTC;             // TANGGAL JAM
  SendData += pemisah;
  SendData += fixdataTegangan1;    // TEGANGAN AKI
  SendData += pemisah;
  SendData += ampereku;            // ARUS DC
  SendData += pemisah;
  SendData += watt;                // DAYA
  SendData += pemisah;
  SendData += ChargeAki;           // STATUS ALAT
  SendData += pemisah;
  SendData += ProteksiRelay;       // RELAY PROTEKSI
  SendData += pemisah;
  SendData += persen_aki;          // PRESENTASI AKI
  if (SendData.length() > 0) {
    ToNode.print(SendData);
    Serial.println(SendData);
  }
}

// PROGRAM TEGANGAN SOLAR CELL
void rtegangan1() {
  value = analogRead(pinV1);
  vOUT = (value * 5.0) / 1024.0;
  vIN = vOUT / (R2 / (R1 + R2));

  if (ChargeAki == "Charging") {
    CMP12 = CMPCharge;
  }
  else {
    CMP12 = CMPNCharge;
  };

  vIN = vIN - CMP12;

  if ((vIN >= 10) && (vIN <= BatasMinAki)) {
    //vIN = 11.6;
  };
  if (vIN < 0) {
    vIN = 0;
  };
  fixdataTegangan1 = vIN ;
  delay(100);
}

// PROGRAM ARUS SOLAR CELL
void pArus1() {
  RawValue = analogRead(analogIn);
  Voltage = (RawValue / 1024.0) * 5000; // Gets you mV
  Amps = ((Voltage - ACSoffset) / mVperAmp);
  ampereku = (Amps * 1000);
  if (Amps < 0) {
    Amps = 0;
  }
  if (ampereku < 0) {
    ampereku = 0;
  }
}

// PROGRAM WATT METER
void wattmeter() {
  watt = fixdataTegangan1 * Amps;
}

// PARSING DATA
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
  dataset_tegangan = (dt[0].toFloat());
  dataset_arus = (dt[1].toFloat());
  dataset_control = (dt[2]);
  dataset_timea = (dt[3].toInt());
  dataset_timeb = (dt[4].toInt());

  jamawalcharge = dataset_timea;
  jamakhircharge = dataset_timeb;
  StatusAlat = dataset_control;

  Serial.println();
  Serial.println("============ NEW DATA ============");
  Serial.print(dataset_tegangan);
  Serial.print(" | ");
  Serial.print(dataset_arus);
  Serial.print(" | ");
  Serial.print(dataset_control);
  Serial.print(" | ");
  Serial.print(dataset_timea);
  Serial.print(" | ");
  Serial.println(dataset_timeb);
  Serial.println();
}

// GET DATA DARI NODEMCU
void KomFromNode() {
  while (FromNode.available()) {
    delay(10);
    char j = FromNode.read();
    GetData += j;
  }
}

void ProgRTC() {
  t = rtc.getTime();
  GetHour = t.hour, DEC;

  TanggalRTC = rtc.getDateStr();
  TimeRTC = rtc.getTimeStr();
  DateRTC = TanggalRTC + "-" + TimeRTC;

  //Serial.println(DateRTC);

  DRelayCharge = DRelay * con_time;

  // PROGRAM RELAY CHARGING

  // NEW PROGRAM
  if (StatusAlat == "On") {
    digitalWrite(MyRelay, RHigh);
    ChargeAki = "Charging";
  }
  else if (StatusAlat == "Auto") {
    if (battraifull == true) {
      digitalWrite(MyRelay, RLow);
      ChargeAki = "Not%20Charging";
    }
    else if (battraifull == false) {
      if ((GetHour >= jamawalcharge) && (GetHour <= jamakhircharge)) {
        digitalWrite(MyRelay, RHigh);
        ChargeAki = "Charging";
      } else {
        digitalWrite(MyRelay, RLow);
        ChargeAki = "Not%20Charging";
      };
    };
  }
  else if (StatusAlat == "Off") {
    digitalWrite(MyRelay, RLow);
    ChargeAki = "Not%20Charging";
  };

  // OLD PROGRAM
  //  if ((GetHour >= jamawalcharge) && (GetHour <= jamakhircharge) || (StatusAlat == "On")) {
  //    digitalWrite(MyRelay, RHigh);
  //    ChargeAki = "Charging";
  //  }
  //  else if ((GetHour >= jamawalcharge) && (GetHour <= jamakhircharge) && (StatusAlat == "Auto")) {
  //    digitalWrite(MyRelay, RHigh);
  //    ChargeAki = "Charging";
  //  }
  //  else {
  //    delay(DRelayCharge);
  //    digitalWrite(MyRelay, RLow);
  //    ChargeAki = "Not%20Charging";
  //  };
}

void proteksiAki() {
  if (count_proteksi <= 5) {
    if ((ampereku >= dataset_arus) || (fixdataTegangan1 >= dataset_tegangan)) {
      digitalWrite(MyRelay2, RHigh);
      ProteksiRelay = "Active";
      count_proteksi += 1;
      delay(5000);
      digitalWrite(MyRelay2, RLow);
      ProteksiRelay = "Idle";
    }
    //    else {
    //      digitalWrite(MyRelay2, RLow);
    //      ProteksiRelay = "Idle";
    //    }
  } else {
    digitalWrite(MyRelay2, RHigh);
    ProteksiRelay = "Active%20R";
    digitalWrite(MyRelay, RLow);
    ChargeAki = "Not%20Charging";
  };
}
