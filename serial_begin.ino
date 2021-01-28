void setup() 
{
  // put your setup code here, to run once:
  Serial.begin(38400);
  
}
void loop() 
{
  String command = "";

  if(Serial.available() > 0)
  {
    while(Serial.available() > 0)
    {
      command += char(Serial.read());
      delay(250);
    }

    println(command);
  }
}
