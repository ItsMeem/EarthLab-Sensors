/* Tilt Meter
 *  
 *  A tilt sensor that is meant to be able to identify the angle of tilt through the use of
 *  a Memsic 2125 Accelorometer.
 */

// Establish the pins to use for output
const int xPin = 2;        // X output of the accelerometer
const int yPin = 3;        // Y output of the accelerometer

void setup() {
  // initialize serial communications:
  Serial.begin(9600);
  
  // initialize the pins connected to the accelerometer
  // as inputs:
  pinMode(xPin, INPUT);
  pinMode(yPin, INPUT);
}

void loop() {
  // variable to read the pulse widths:
  int pulseX;
  
  // variables to contain the resulting accelerations
  int accelerationX;
  float xGForce, Xangle;

  // read pulse from x:
  pulseX = pulseIn(xPin, HIGH);
  
  // convert the pulse width into acceleration
  // accelerationX and accelerationY are in milli-g's:
  // earth's gravity is 1000 milli-g's, or 1g.
  accelerationX = (( ((float)pulseX) / 10) - 500) * 8;

  //get xangle in radians
  Xangle = asin( (float)accelerationX / 1000.0 );

  //change angle from radians to degrees
  Xangle = Xangle*(360/(2*M_PI));

  //add the starting offset
  Xangle = Xangle + 3;

  //take absolute value of any negative number
  if (Xangle <= 0)
  {
    Xangle = Xangle*-1;
  }
  
  //Round down to zero degrees if Xangle is too small
  else if( Xangle > 0 && Xangle <= 0.9)
  {
    Xangle = 0;
  }
  //Scalar multiple to account for angle of container
  else
  {
    Xangle = Xangle * 1.27;
  }

  Serial.print("The Xangle in degrees is ");
  Serial.println(Xangle);
  delay(500);
}
