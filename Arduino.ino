#include "DHT.h"
#include "CTBot.h"

#define DHTPIN D7     
#define DHTTYPE DHT11
#define mqPin D6
#define waterLevel A0  
#define plan1 D3
#define plan2 D4
#define plan3 D5

String ssid  = "Beko";
String pass  = "12345678"; 
String token = "859824019:AAFVAmfTzM0TgN-6xreElqs9HiVh3H2i19o";
bool statusBOt = false;

String gazAlarm;
uint8_t mqStatus ;
int level;
String levelAlarm;
uint8_t h =0;
uint8_t t = 0;
String serialString;
unsigned long timer;
String digit1 = "OFF";
String digit2 = "OFF";
String digit3 = "OFF";

DHT dht(DHTPIN, DHTTYPE);
CTBot myBot;
TBMessage msg; 

void setup() 
{
  Serial.begin(9600);
  Serial.println("Welcome To Mixing Machine Project");
  pinMode(plan1,OUTPUT);
  pinMode(plan2,OUTPUT);
  pinMode(plan3,OUTPUT);

  while(!myBot.wifiConnect(ssid, pass));
  myBot.setTelegramToken(token);
  
  if (myBot.testConnection())
   {
      Serial.println("Connection Success to Telegram BOT  ..");
   }
  else
    {
      Serial.println("Failed Connection to Telegram BOT  !!");
    }
    
      dht.begin();
     timer = millis();
    
}

void loop() 
{
  
  if(millis() - timer >= 1000)
  {
    timer = millis();
    Serial.print(t);
    Serial.print(";");
    Serial.print(h);
    Serial.print(";");
    Serial.print(mqStatus);
    Serial.print(";");
    Serial.print(level);
    Serial.println();
  }
  
  if(Serial.available() > 0)
    {
      readSerial();
    } 
  
    h = dht.readHumidity();
    t = dht.readTemperature();
    level = analogRead(waterLevel);
   //mqStatus = digitalRead(mqPin); 
    mqStatus = 0;
   /*
    if(mqStatus == 1)
    {
      gazAlarm = "No Gaz Detected !!";
    }
    else
    {
      gazAlarm = "Gaz Detected !!";
      //myBot.sendMessage(msg.sender.id,gazAlarm);
    }
    if(level > 25)
    {
      levelAlarm = "No Water";
    }
    else
    {
      levelAlarm = "Found Water";
      //myBot.sendMessage(msg.sender.id,gazAlarm);
    }
  
  if (myBot.getNewMessage(msg))
   {
    telegramCheckMessage();
   }
   */
}

void telegramCheckMessage()
{
        if (msg.text.equalsIgnoreCase("status"))  
         {
            if(statusBOt == false)
              {
               myBot.sendMessage(msg.sender.id,"bot is stop"); 
              }
             else
               {
                 myBot.sendMessage(msg.sender.id,"bot is start");
               }
         }       
            
        
         else if (msg.text.equalsIgnoreCase("start") && statusBOt == false) 
         {
             myBot.sendMessage(msg.sender.id,"Welcome To Mixing Machine Bot");
             statusBOt = true;                                               
         }
         else if (msg.text.equalsIgnoreCase("start") && statusBOt == true) 
         {
             myBot.sendMessage(msg.sender.id,"the bot already started");                                               
         }
         else if (msg.text.equalsIgnoreCase("stop") && statusBOt == true) 
         {
           myBot.sendMessage(msg.sender.id,"Bot Stop , GoodBye");
           statusBOt = false;  
         }
         else if (msg.text.equalsIgnoreCase("stop") && statusBOt == false) 
         {
           myBot.sendMessage(msg.sender.id,"the bot already stopped"); 
         }
        else if (msg.text.equalsIgnoreCase("about")&& statusBOt == true )
         {
           myBot.sendMessage(msg.sender.id,"Creating By Abdulrahman Kazkaz"); 
         }
         else if (msg.text.equalsIgnoreCase("get info")&& statusBOt == true )
         {
              
           myBot.sendMessage(msg.sender.id, String(" Humidty : ") + h + " \n Temperature : " + t + " \n Gaz Status : " + gazAlarm + " \n Level Water : " + levelAlarm ); 
         }
         else if (msg.text.equalsIgnoreCase("digital info")&& statusBOt == true )
         {   
           myBot.sendMessage(msg.sender.id, String(" Digital 1 : ") + digit1 + " \n Digital 2 : " + digit2 + " \n Digital 3 : " + digit3); 
         }
         else if (msg.text.equalsIgnoreCase("help"))
         {
           myBot.sendMessage(msg.sender.id,"start : start bot \n stop : stop bot \n about : get info owner \n status : get status bot \n get info : show value to sensor \n on(1,2,3) : turn on output digital \n off(1,2,3)turn off output digital \n digital info : get status Digital Output "); 
         }

         else if (msg.text.equalsIgnoreCase("on 1")&& statusBOt == true)
         {
           digitalWrite(plan1,HIGH);
           myBot.sendMessage(msg.sender.id,"Turn ON");
           digit1 = "ON";
         }
         else if (msg.text.equalsIgnoreCase("off 1")&& statusBOt == true)
         {
           digitalWrite(plan1,LOW);
           myBot.sendMessage(msg.sender.id,"Turn OFF");
           digit1 = "OFF";
         }
         else if (msg.text.equalsIgnoreCase("on 2")&& statusBOt == true)
         {
           digitalWrite(plan2,HIGH);
           myBot.sendMessage(msg.sender.id,"Turn ON");
           digit2 = "ON";
         }
         else if (msg.text.equalsIgnoreCase("off 2")&& statusBOt == true)
         {
           digitalWrite(plan2,LOW);
           myBot.sendMessage(msg.sender.id,"Turn OFF");
           digit2 = "OFF";
         }
         else if (msg.text.equalsIgnoreCase("on 3")&& statusBOt == true)
         {
           digitalWrite(plan3,HIGH);
           myBot.sendMessage(msg.sender.id,"Turn ON");
           digit3 = "ON";
         }
         else if (msg.text.equalsIgnoreCase("off 3")&& statusBOt == true)
         {
           digitalWrite(plan3,LOW);
           myBot.sendMessage(msg.sender.id,"Turn OFF");
           digit3 = "OFF";
         }
         else if (statusBOt == false)
         {
          myBot.sendMessage(msg.sender.id," Bot is Stopped , Please enter start to turn on bot");
         }
         else if(statusBOt == true)
         {
          myBot.sendMessage(msg.sender.id,"Not Found Command , Please enter help to Get all Command");
         }
          
}

void readSerial()
{
  
      serialString = Serial.readString();
      //////////////////////////////////////
      if(serialString == "on1")
      {
        digitalWrite(plan1,HIGH);
      }
      else if(serialString == "off1")
      {
        digitalWrite(plan1,LOW);
      }
      /////////////////////////////////////
      else if(serialString == "on2")
      {
        digitalWrite(plan2,HIGH);
      }
      else if(serialString == "off2")
      {
        digitalWrite(plan2,LOW);
      }
      ////////////////////////////////////
      else if(serialString == "on3")
      {
        digitalWrite(plan3,HIGH);
      }
      else if(serialString == "off3")
      {
        digitalWrite(plan3,LOW);
      }
  }
