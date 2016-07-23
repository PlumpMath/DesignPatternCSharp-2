using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class SaltWater
    {
        public double salt;
        public double water;
        public SaltWater(double water, double salt)
        {
            this.salt = salt;
            this.water = water;
        }
    }
}
