//Sample using SD02C UART and LCD.
#include <LiquidCrystal.h>
#include <SoftwareSerial.h>
/*******************************************************

This program will test the LCD panel and the buttons
Mark Bramwell, July 2010


                                                                COMMAND
      	 ON_OFF 		            :1;             //bit0          F = OFF, O = ON
      	 CW_CCW 		            :1;             //bit1          < = COUNTER CLOCKWISE   , > = CLOCKWISE
      	 GO_BRAKE 	            :1;             //bit2          G = G0 , B = BRAKE
      	 FB_ENCODER             :1;             //bit3          E = ENCODER
      	 SPEED			            :1;             //bit4          S = SPEED
      	 RESET_ENCODER          :1;             //bit5          R = RESET ENCODER
         TRACK 			            :2;		//bit6-7        T = TRACK 
	 I_SENSE		                  :1;		//bit8          I = CURRENT        // NOT USE
	 THRESHOLD		                :1;		//bit9          H = THRESHOLD      // NOT USE
	 BAUDRATE		                  :1;		//bit10         U = BAUDRATE
	 STATUS			                  :1;		//bit11         C = STATUS
	 ACCELERATE		                :2;		//bit12-13      A = ACCELERATE
	 MICROSTEP		                :1;		//bit14         M = MICROSTEP      

********************************************************/

SoftwareSerial mySerial(2, 3); // RX, TX

#define PULSE        11
#define DIRECTION    12
#define EN           13

// select the pins used on the LCD panel
LiquidCrystal lcd(8, 9, 4, 5, 6, 7);

// define some values used by the panel and buttons
int lcd_key     = 0;
int adc_key_in  = 0;
#define btnRIGHT  0
#define btnUP     1
#define btnDOWN   2
#define btnLEFT   3
#define btnSELECT 4
#define btnNONE   5

void rotate();

// read the buttons
int read_LCD_buttons()
{
 adc_key_in = analogRead(0);      // read the value from the sensor 
 // my buttons when read are centered at these valies: 0, 144, 329, 504, 741
 // we add approx 50 to those values and check to see if we are close
 if (adc_key_in > 1000) return btnNONE; // We make this the 1st option for speed reasons since it will be the most likely result
 // For V1.1 us this threshold
 if (adc_key_in < 100)   return btnRIGHT;  
 if (adc_key_in < 600)  return btnUP; 
 if (adc_key_in < 700)  return btnDOWN; 
 if (adc_key_in < 800)  return btnLEFT; 
 if (adc_key_in < 900)  return btnSELECT;  

 // For V1.0 comment the other threshold and use the one below:
/*
 if (adc_key_in < 50)   return btnRIGHT;  
 if (adc_key_in < 195)  return btnUP; 
 if (adc_key_in < 380)  return btnDOWN; 
 if (adc_key_in < 555)  return btnLEFT; 
 if (adc_key_in < 790)  return btnSELECT;   
*/

 return btnNONE;  // when all others fail, return this...
}

int i =0;

int pul = 0;
int dir = 0;
int enable =0;
int startrun = 0;

void setup()
{
   //pinMode(10, OUTPUT);
   pinMode(11, OUTPUT);
   pinMode(12, OUTPUT);  
   pinMode(13, OUTPUT); 
  mySerial.begin(9600);
 lcd.begin(16, 2);              // start the library
 lcd.setCursor(0,0);
 //lcd.print("Push the buttons"); // print a simple message  
}
 
void loop()
{
         lcd.setCursor(0,0);
         lcd.print("En");
         lcd.setCursor(0,1);
         lcd.print(enable);
         
         lcd.setCursor(3,0);
         lcd.print("Run");
         lcd.setCursor(3,1);
         lcd.print(startrun);
         
         lcd.setCursor(7,0);
         lcd.print("PULSE");
         lcd.setCursor(7,1);
         lcd.print(pul);
         lcd.print(" ");
         lcd.print((char)127);
         lcd.print((char)126);
         
         lcd.setCursor(13,0);
         lcd.print("Dir");
         lcd.setCursor(13,1);
         lcd.print(dir);

 //lcd.setCursor(0,1);            // move to the begining of the second line
 lcd_key = read_LCD_buttons();  // read the buttons

 switch (lcd_key)               // depending on which button was pushed, we perform an action
 {
   case btnRIGHT:
     {
        dir ^=1;      
        delay(300);
               
        if(dir==1)                       // stop
	{
        digitalWrite(DIRECTION, HIGH);
        mySerial.print(">");
	}
        else
        {
        digitalWrite(DIRECTION, LOW);   
        mySerial.print("<");   
        }
     break;
     }
   case btnLEFT:
     {
       
        startrun ^=1;      
        delay(300);
        
        if(startrun==1)                       // stop
	      {
         mySerial.print("G");
	      }
        else
        {
         mySerial.print("B");     
        }
     break;
     }
   case btnUP:
     {    
        if(pul<255)                       // stop
	   {
       lcd.setCursor(7,1);
       lcd.print("     ");
       pul++;
       delay(250);
	    }
      mySerial.print("S"); 
      mySerial.write(pul);
      break;
      }
   case btnDOWN:
      {
       
        if(pul>0)                       // stop
	    {
        lcd.setCursor(7,1);
        lcd.print("     ");
        pul--;
        delay(250);
	    }
        mySerial.print("S"); 
        mySerial.write(pul);
        break;
      }
   case btnSELECT:
      {
                     
        enable ^=1;      
        delay(300);
        if(enable==1)                       // stop
	      {
        digitalWrite(EN, HIGH);
        mySerial.print("O");
	      }
        else
        {
        digitalWrite(EN, LOW);
        mySerial.print("F");      
        }
     break;
     }
     case btnNONE:
     { 
        if(startrun==1)                       // stop
	      {
         rotate();
	      }
        else
        {
         digitalWrite(PULSE, LOW);   
        }    
     break;
     }
 }
}

void rotate(){

            	if(pul==0)                       // stop
	            {
		          digitalWrite(PULSE, LOW); 
	             }
	            else
	             {
		            i = (256-pul)*100;              //the higher the value of pul, the faster the steps change. multiply 100 to see speed incrememt
		            digitalWrite(PULSE, HIGH);                     //set pulse pin on motor driver
                delayMicroseconds(i);
		            digitalWrite(PULSE, LOW);                     //clear pulse pin on motor driver
                delayMicroseconds(i);
	              } 
}



