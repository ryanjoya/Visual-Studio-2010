using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingOO
{
    class AssemblyRobot
    {
        public string Name { get; set; }

        public int MyProperty { get; set; }
        
        
        public static Automobile AssembleCar(string model, Engine engineType)
        {
            Automobile newCar = new Automobile();
            newCar.Model = model;
            newCar.Engine = engineType;
            return newCar;
        }
    }
}
