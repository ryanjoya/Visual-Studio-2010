using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingOO
{
    class Truck : Automobile
    {
        public int TowingCapacity;
        public int CargoCapacity;

        public void Tow()
        {
            Console.WriteLine("Now towing ...");
        }

        public void Haul()
        {
            Console.WriteLine("Now hauling ...");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Truck ignition sequence ...");
        }

    }
}
