using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class AgeComparator : Comparator
    {
        public int compare(Human h1, Human h2)
        {
            if (h1.age > h2.age)
            {
                return 1;
            }
            else if (h1.age == h2.age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
