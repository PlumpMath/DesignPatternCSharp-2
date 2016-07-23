using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            HotPot hotPot = new HotPot(new Pot());
            Factory factory = createFactory(args[0]);
            hotPot.addSoup(factory.getSoup());
            hotPot.addMain(factory.getMain());
            hotPot.addVegetables(factory.getVegetables());
            hotPot.addOtherIngredients(factory.getOtherIngredients());
        }

        private static Factory createFactory(String str)
        {
            if (str == "キムチ鍋")
            {
                return new KimuchiFactory();
            }
            else if (str == "すき焼き")
            {
                return new SukiyakiFactory();
            }
            else
            {
                return new MizutakiFactory();
            }
        }
    }
}
