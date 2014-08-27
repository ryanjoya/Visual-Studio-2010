using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day5Homework
{
    class ElementalMutant
    {
        public int Region;
        public int DQ;

        public override void DangerQuotient()
        {
            DQ = Region * Level;
        }

    }
}
