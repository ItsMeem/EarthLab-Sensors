/*
  Voltmeter
  
  Voltmeter based on voltage divider concept. The typical Arduino Uno is capable of reading 
  only between 6-20V worth of power before it becomes overloaded, thus we needed to construct
  a voltage divider circuit to allow for readings from up to 60V from our Solar Panel.
*/

// variables for input pin and control LED
  int analogInput = 1;
  
  float vout = 0.0;
  float vin = 0.0;
  
  float R1 = 50000.0;    // !! resistance of R1 !!
  float R2 = 4400.0;     // !! resistance of R2 !!

// variable to store the value 
  double value = 0.0;

void setup()
{  
  Serial.begin(9600);
  
  // declaration of pin modes, set analogInput to INPUT
  pinMode(analogInput, INPUT);
}

void loop(){
  // read the value on analog input
  value = analogRead(analogInput);

  vout = (value * 50) / 1024.0;

  //Actual voltage that is measured from the panels 
  //Manipulate the multiple to get accurate reading
  vin = vout * 1.224;

  //Actual voltage into arduino (manipulate the multiple) 
  //vin = vout * 1.224 * (R2/(R1+R2)))

  //Print out the readings
  Serial.print("The voltage reading is ");
  Serial.print(vin);
  Serial.println();

  // sleep...
  delay(500);
}
