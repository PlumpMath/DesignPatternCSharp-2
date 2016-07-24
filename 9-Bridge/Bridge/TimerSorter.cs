using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class TimerSorter : Sorter
    {
        public void timerSorter(Object[] obj)
        {
            long start = DateTime.Now.Ticks;
            sort(obj);
            long end = DateTime.Now.Ticks;
            Console.WriteLine("time:" + (end - start));
        }
    }
}
