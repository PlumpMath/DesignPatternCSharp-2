using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Sorter
    {
        private SortImple sortImple;
        public Sorter(SortImple sortImple)
        {
            this.sortImple = sortImple;
        }
        public void sort(Object[] obj)
        {
            sortImple.sort(obj);
        }
    }
}
