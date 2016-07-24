using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface Comparator
    {
        int compare(Human h1, Human h2);
    }
}
