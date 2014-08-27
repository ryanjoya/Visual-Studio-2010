using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay4
{
    class Personnel: Asset
    {
        public string Department;
        public string Supervisor;

        public Personnel(string Department, string Supervisor, string CodeName, string Region, string SkillSet)
        {
            Console.WriteLine("Initializing ...");
            Console.WriteLine(Department);
            Console.WriteLine(Supervisor);
            Console.WriteLine(CodeName);
            Console.WriteLine(Region);
            Console.WriteLine(SkillSet);
            Console.ReadLine();
        }
    }
}
