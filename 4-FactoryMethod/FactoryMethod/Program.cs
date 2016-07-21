using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagawa = new ImagawasCutPrint();
            imagawa.createCutPrint();

            Console.ReadKey();
        }
    }
}
