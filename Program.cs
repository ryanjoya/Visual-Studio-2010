using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Global_Spy_Analysis_Application_Class_Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy JamesBond = new Spy();
            Agency MI6 = new Agency(); 
            JamesBond.CodeName = "007";
            JamesBond.SpyAgency = MI6;
            JamesBond.DateLastSeen = DateTime.Now;
            JamesBond.Notes = "E F#F#F#F# E E E E G G G F#F#F#";

            JamesBond.DisplaySpyInfo();

        }
    }
}
