int LED_PIN = 7;
int peltier_1 = 3; //The N-Channel MOSFET is on digital pin 3
int peltier_2 = 11; 
int power = 0; //Power level fro 0 to 99%
int peltier_level = map(power, 0, 99, 0, 255); //This is a value from 0 to 255 that actually controls the MOSFET
int state;

void setup(){
  pinMode(LED_PIN, OUTPUT);
  
  Serial.begin(9600);
  //pinMode(peltier, OUTPUT);
  digitalWrite(LED_PIN, LOW);
  }

void loop(){
  //char option;
  if(Serial.available()) {
    char ch = Serial.read();
    if (ch == 'n') {
      digitalWrite(LED_PIN, LOW);
    }
    else {
      digitalWrite(LED_PIN,HIGH);
    }
  }
  
  /*if(Serial.available() > 0)
  {
  option = Serial.read();
  if(option == 'a') 
  power += 2;
  else if(option == 'z')
  power -= 2;
  
  if(power > 99) power = 99;
  if(power < 0) power = 0;
  
  peltier_level = map(power, 0, 99, 0, 255);
  }
  
  Serial.print("Power=");
  Serial.print(power);
  Serial.print(" PLevel=");
  Serial.println(peltier_level);
  
  analogWrite(peltier_1, peltier_level); //Write this new value out to the port
  analogWrite(peltier_2, peltier_level); //Write this new value out to the port
*/

}
