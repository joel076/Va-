int micPin = A0;
int gndPin = A1;
int powerPin = A2;
int micValue1 = 0;
int micValue2 = 0;
int led1 = 11;
int eventstatus = 0;

void setup() {

  pinMode(led1, OUTPUT);
  pinMode(powerPin, OUTPUT);
  pinMode(gndPin, OUTPUT);
  pinMode(micPin, INPUT);
  digitalWrite(gndPin,LOW);
  delay(500);
  digitalWrite(powerPin,HIGH);
  Serial.begin(9600);
}
//micValue1-micValue2 < 2||micValue2-micValue1 < 2
//micValue1 < 60
void loop() {
  // put your main code here, to run repeatedly:
  micValue1 = analogRead(micPin);
    micValue2 = analogRead(micPin);
  delay(1);

  if(micValue1 > 44||micValue1 > 44 && eventstatus == 0){
    Serial.println("0");
    eventstatus = 1;
  }
  
      if(eventstatus==1){  
    for(int k =10; k>0;k--){
      delay(10);
        micValue1 = analogRead(micPin);
    micValue2 = analogRead(micPin);
      if(micValue1 < 44){
        eventstatus=2;
        Serial.println("1");
        break;
      } 
    }
      } 

        
        if(eventstatus==2){
    for(int n=25;n>0;n--){
      delay(1);
        micValue1 = analogRead(micPin);
    micValue2 = analogRead(micPin);
      if(micValue1 > 44){
        eventstatus=3;
        Serial.println("2");
      break;
      }
    }
        }
        


      
        if(eventstatus==3){
            myservo.write(100);
            delay(1000);
    Serial.println("Nice");
    eventstatus = 0;
    digitalWrite(led1,HIGH);
    delay(2000);
        digitalWrite(led1,LOW);
        delay(1000);
  }  
  }

