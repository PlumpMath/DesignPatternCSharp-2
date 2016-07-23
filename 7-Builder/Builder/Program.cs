using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new SaltWaterBuilder();
            Director dir = new Director(builder);
            dir.constract();
            SaltWater saltWater = (SaltWater)builder.getResult();

            Console.ReadKey();
        }
    }
}
