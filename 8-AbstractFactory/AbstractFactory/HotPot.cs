using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HotPot
    {
        private Pot pot;
        private Soup soup;
        private Protein protein;
        private List<Vegetable> vegetables;
        private List<Ingredients> otherIngredients;
        public HotPot(Pot pot)
        {
            this.pot = pot;
        }
        public void addSoup(Soup soup)
        {
            this.soup = soup;
        }
        public void addMain(Protein protein)
        {
            this.protein = protein;
        }
        public void addVegetables(List<Vegetable> vegetables)
        {
            this.vegetables = vegetables;
        }
        public void addOtherIngredients(List<Ingredients> otherIngredients)
        {
            this.otherIngredients = otherIngredients;
        }
    }
}
