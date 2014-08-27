using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingOO
{
    class Automobile
    {
        private string make;
        public string Model;
        public int Year;
        public string Color;
        public int Miles;
        private int speed;
        public Engine Engine;

        public Automobile()
        {
            // Do important initialization stuff here
            Console.Write("Initializing ...");
        }
        

        public AutoCustomer Customer = new AutoCustomer();

        public class AutoCustomer
        {
            public string LastName;
            public string Address;
            public DateTime DateOfPurchase;
        }

        private string myOtherValue;
        public string Maker
        {
            get { return make; }
            set {
                    switch(value)
                  {
                    case "Oldsmobile":
                        make=value;
                        break;
                    case "Toyota":
                        make=value;
                        break;
                    default:
                        throw new Exception ("Not a valid Maker");
                 }
            }
        }

        public int CurrentSpeed
        {
            get { return speed; }
            set {
                if (value < 0)
                    speed = 0;
                else if (value > 110)
                    speed = 110;
                else
                    speed = value;
            }
        }

        public int Accelerate(int increasedSpeed)
        {
            CurrentSpeed += increasedSpeed;
            writeLine("Current speed: " + CurrentSpeed);            
            //Console.WriteLine("Current speed: " + Speed.ToString());
            return CurrentSpeed;
        }

        public int Decelerate(int decreasedSpeed)
        {
            CurrentSpeed -= decreasedSpeed;
            //Console.WriteLine("Current speed: " + Speed.ToString());
            writeLine("Current speed: " + CurrentSpeed);
            return CurrentSpeed;
        }

        public string SpeedLimitViolation(string initialMessage, int speedLimit)
        {
            string message = "";

            if (CurrentSpeed > speedLimit)
                message="JEWFastJEWSerious";
            else
                message="You got served";

            return initialMessage + " " + message;
        }

        private void writeLine(string message)
        {
            if (message!=null)
            {
                Console.Write("FROM MY HELPER METHOD ...");
                Console.WriteLine(message); 
            }
           
        }

        public virtual void Start()
        {
            Console.WriteLine("Starting ...");
        }


    }
}
