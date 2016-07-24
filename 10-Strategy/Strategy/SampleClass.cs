using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class SampleClass
    {
        private Comparator comparator = null;
        public SampleClass(Comparator comparator)
        {
            this.comparator = comparator;
        }
        public int compare(Human h1, Human h2)
        {
            return comparator.compare(h1, h2);
        }
    }
}
