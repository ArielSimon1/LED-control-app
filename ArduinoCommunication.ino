
#include <LiquidCrystal.h>

// definition of global variables

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";
int leds[6] = {2,3,4,5,6,7}; //array holding led ports
boolean isConnected = false;

// turn led ON while specific pin number (int) is given
void turnLedOn(int pin)
{
  digitalWrite(pin,HIGH);
}

// turn led OFF while specific pin number (int) is given
void turnLedOff(int pin)
{
  digitalWrite(pin,LOW);
}

// Arduino setup function - connect each pin to led in the led string
void setup() {
  
  Serial.begin(9600);
  for(int i=0 ; i<6 ;i++){
		pinMode(leds[i],OUTPUT);
    if(digitalRead(leds[i]) == HIGH) //checking wether the current led is in ON state and turning it off
      turnLedOff(leds[i]);
  }
}

// Arduino loop function - "translate" strings from the Visual Studio to actions in the Arduino board
void loop() {
// check if "stringComplete" flag is ON (it is ON while the input string ends with "\n")
if(stringComplete)
{
  stringComplete = false; //change the flag to "OFF" again, so arduino can get another strings
  getCommand();
  
  if(commandString.equals("STAR"))
  {
    for(int i=0 ; i<6 ;i++)
		if(digitalRead(leds[i]) == HIGH) //checking wether the current led is in ON state and turning it off
      turnLedOff(leds[i]);
  }
  if(commandString.equals("STOP"))
  {
	for(int i=0 ; i<6 ;i++)
		if(digitalRead(leds[i]) == HIGH) //checking wether the current led is in ON state and turning it off
      turnLedOff(leds[i]); 
  }
  else if(commandString.equals("LED1"))
  {
    boolean LedState = getLedState();
    if(LedState == true)
    {
      turnLedOn(leds[0]);
    }else
    {
      turnLedOff(leds[0]);
    }   
  }
  else if(commandString.equals("LED2"))
  {
    boolean LedState = getLedState();
    if(LedState == true)
    {
      turnLedOn(leds[1]);
    }else
    {
      turnLedOff(leds[1]);
    }   
  }
  else if(commandString.equals("LED3"))
  {
    boolean LedState = getLedState();
    if(LedState == true)
    {
      turnLedOn(leds[2]);
    }else
    {
      turnLedOff(leds[2]);
    }   
  }
  else if(commandString.equals("LED4"))
  {
    boolean LedState = getLedState();
    if(LedState == true)
    {
      turnLedOn(leds[3]);
    }else
    {
      turnLedOff(leds[3]);
    }   
  }
  else if(commandString.equals("LED5"))
  {
    boolean LedState = getLedState();
    if(LedState == true)
    {
      turnLedOn(leds[4]);
    }else
    {
      turnLedOff(leds[4]);
    }   
  }
  else if(commandString.equals("LED6"))
  {
    boolean LedState = getLedState();
    if(LedState == true)
    {
      turnLedOn(leds[5]);
    }else
    {
      turnLedOff(leds[5]);
    }   
  }
  else if(commandString.substring(0,3).equals("CYC"))
  { int index = 4;
  
   /// extract Hz value - read the string till "A"
  
    String tmp = "";
    String hz_str = "";
    while (!inputString.substring(index, index+1).equals("A")){
      tmp =  inputString.substring(index, index+1);
      hz_str += tmp;
    tmp = "";
    index++;
      }  
int hz =  hz_str.toInt();
int delay_value = 1000/hz; // --> 1s/5 = 1000ms/5 = 200ms delay

/// **** checkPoint *** ///
//turnLedOn(leds[hz]);
/// **** checkPoint *** ///

 /// extract time value - read the string till "b"
index++;
String seconds_str = "";
while (!inputString.substring(index, index+1).equals("B")){
  
tmp = inputString.substring(index, index+1);
      seconds_str =  seconds_str + tmp;
    tmp = "";
    index++;
      }  
int seconds = seconds_str.toInt();
int mili_seconds = seconds*1000;
int second_cycle = mili_seconds/delay_value; // 10 times of 200 ms -->2000ms = 2 s

/// **** checkPoint *** ///
//turnLedOn(leds[seconds]);
/// **** checkPoint *** ///

index++;
 /// extract breakTime value - read the string till "C"

String breakTime_str = ""; // seconds
while (!inputString.substring(index, index+1).equals("C")){
  tmp = inputString.substring(index, index+1);
      breakTime_str =  breakTime_str + tmp;
    tmp = "";
    index++;
      }       
int breakTime = breakTime_str.toInt()*(1000);
/// **** checkPoint *** ///
//turnLedOn(leds[breakTime/1000]);
/// **** checkPoint *** ///

index++;
/// extract repeats value - read the string till "D"

String repeats_str = "";
while (!inputString.substring(index, index+1).equals("D")){
   tmp = inputString.substring(index, index+1);
      repeats_str =  repeats_str + tmp;
    tmp = "";
    index++;
      }    
int repeats = repeats_str.toInt();
/// **** checkPoint *** ///
//turnLedOn(leds[repeats]);
/// **** checkPoint *** ///


/// THE MAIN LOOP
for (int y=0; y<repeats; y++){
  for (int x=0; x<second_cycle; x++){
           for(int i=0 ; i<6 ;i++){
turnLedOn(leds[i]);
}
        for(int j=0 ; j<6 ;j++){turnLedOff(leds[j]);
  }
   delay(delay_value);
}
delay(breakTime);
}
  }
  inputString = "";
}

}

boolean getLedState()
{
  boolean state = false;
  if(inputString.substring(5,7).equals("ON"))
  {
    state = true;
  }else
  {
    state = false;
  }
  return state;
}

// extract the first 4 characters of the inputString as a Command
void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(1,5);
  }
}

// communication function of Arduino with Visual studio through the Port
void serialEvent() {
  // the loop runs all time that port is open, read the given string from the first char "#" to the last char "\n"
  // while recognize an "\n", it change the flag "stringComplete" to true so the loop function can "translate it" to LED actions.
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
