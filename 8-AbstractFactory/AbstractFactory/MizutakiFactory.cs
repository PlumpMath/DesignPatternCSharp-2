using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MizutakiFactory : Factory
    {
        public override Soup getSoup()
        {
            return new ChickenBonesSoup();
        }
        public override Protein getMain()
        {
            return new Chicken();
        }
        public override List<Vegetable> getVegetables()
        {
            List<Vegetable> vegetables = new List<Vegetable>();
            vegetables.Add(new ChineseCabbage());
            vegetables.Add(new Leek());
            vegetables.Add(new Chrysanthemum());
            return vegetables;
        }
        public override List<Ingredients> getOtherIngredients()
        {
            List<Ingredients> otherIngredients = new List<Ingredients>();
            otherIngredients.Add(new Tofu());
            return otherIngredients;
        }
    }
}
