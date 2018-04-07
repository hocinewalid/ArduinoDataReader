int message = 1;

void setup(){
  Serial.begin(9600);

}

void loop(){
  Serial.println("le message du jour est : " +String(message));
  message++;
  delay(1000);
}
