using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class HeightComparator : Comparator
    {
        public int compare(Human h1, Human h2)
        {
            if (h1.height > h2.height)
            {
                return 1;
            }
            else if (h1.height == h2.height)
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
