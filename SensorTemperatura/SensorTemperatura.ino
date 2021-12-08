//Sensor de temperatura
//  10 [mV/C]
//  analogRead() - 0 - 1023 
//  5000 [mV]
// T= 5000/10*analogRead()/1023
const int AnalogIn=0;
int Temperatura ; //Variable que determina la temperatura
void setup() {
  Serial.begin(9600);
}

void loop() {
  Temperatura= 500*analogRead(AnalogIn)/1023;
  Serial.write(Temperatura);
  //Serial.println(Temperatura);
  delay(1000);

}
