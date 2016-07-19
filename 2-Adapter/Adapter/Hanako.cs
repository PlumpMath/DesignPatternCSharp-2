using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Hanako : Chairperson
    {
        private Taro taro;
        public Hanako()
        {
            taro = new Taro();
        }
        public void organizeClass()
        {
            taro.enjoyWithAllClassmate();
        }
    }
}
