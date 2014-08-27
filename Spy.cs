using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Global_Spy_Analysis_Application_Class_Diagram
{
    class Spy
    {
        public string CodeName;
        public Agency SpyAgency;
        public DateTime DateLastSeen;
        public string Notes;
        
        public void DisplaySpyInfo()
        {
            Console.WriteLine(CodeName);
            Console.WriteLine(Notes);
            Console.WriteLine(DateLastSeen);
            Console.ReadLine();
        }
    }
}
