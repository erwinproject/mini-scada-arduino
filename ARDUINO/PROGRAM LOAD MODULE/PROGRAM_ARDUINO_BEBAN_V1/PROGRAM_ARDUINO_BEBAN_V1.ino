/* ======================================================================
                    PROGRAM MIKROKONTROLER BEBAN V1
   ======================================================================
   ERWIN NUR CAHYONO | erwinproject.id@gmail.com
   PROGRAM FITURE :
   [+] PZEM 004 ENERGY MONITORING
   [+] SEND DATA TO NODEMCU V3
   ======================================================================
*/
#include <SoftwareSerial.h>
#include <Wire.h>
#include <PZEM004T.h>

#define rxpzem        2
#define txpzem        3
#define rx1           11   // KOMUNIKASI KE NODEMCU
#define tx1           12
#define br            57600

PZEM004T pzem(rxpzem, txpzem);
IPAddress ip(192, 168, 1, 1);
SoftwareSerial ToNode (rx1, tx1);

int i;
float v, amp, p, e, PF;
double ifix;

String dt[10];
String GetData = "", SendData = "", pemisah = "|";
float datav1, dataa2;

void setup() {
  Serial.begin(br);
  ToNode.begin(br);
  pzem.setAddress(ip);
}

void loop() {
  //trial();
  pzemprog();           // PROGRAM PZEM-004
  amp = amp * 1000;
  Serial.print(PF);
  sendNode();           // MENGIRIM DATA KE NODEMCU
  //delay(500);
}

// PROGRAM PZEM-004
void pzemprog() {
  v = pzem.voltage(ip);
  if (v < 0.0) v = 0.0;

  amp = pzem.current(ip);
  ifix = amp - 0.04;
  if (amp < 0.0 || ifix < 0.0) {
    amp = 0.0;
    ifix = 0.0;
  };

  //p = v * amp;
  p = pzem.power(ip);
  if (p < 0.0) p = 0.0;

  e = pzem.energy(ip);
  PF = ((p) / (v * amp));
  //  PF = ((v * amp) / p);

  delay(100);
}

void trial() {
  v = 1000;
  amp = 1;
  p = 0;
  PF = 1;
}

// SEND DATA TO NODEMCU
void sendNode() {
  SendData = pemisah;
  SendData += v;
  SendData += pemisah;
  SendData += amp;
  SendData += pemisah;
  SendData += p;


  if (SendData.length() > 0) {
    ToNode.print(SendData);
    Serial.println(SendData);
  }
}

// READ SEND DATA TO NODEMCU
void KomToNode() {
  while (ToNode.available()) {
    delay(10);
    char c = ToNode.read();
    SendData += c;
  }
}
