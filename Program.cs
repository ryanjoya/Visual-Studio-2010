using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type in the numbers and press Return:");
            
            string userValue = "";
            string message = "";
            
            userValue = Console.ReadLine();
                        
            if (userValue == "4 8 15 16 23 42")
            {
                message = "Recalibrating energy core ... Complete.";
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                message = "Failure! It's the end of the world!";
                Console.Beep();
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
