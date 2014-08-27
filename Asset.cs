using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay4
{
    class Asset
    {
        public string CodeName;
        public string Region;
        public string SkillSet;

        public virtual void Print()
        {
            Console.WriteLine(CodeName);
            Console.WriteLine(Region);
            Console.WriteLine(SkillSet);
            Console.ReadLine();
        }
    }
}
