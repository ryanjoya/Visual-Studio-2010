using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel myPersonnel = new Personnel("MI6", "M", "007", "UK", "License to Kill");
            Agent myAgent = new Agent();
            myAgent.Print();
            
        }
    }
}
