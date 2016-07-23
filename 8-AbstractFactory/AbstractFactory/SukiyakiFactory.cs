using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class SukiyakiFactory : Factory
    {
        public override Protein getMain()
        {
            throw new NotImplementedException();
        }

        public override List<Ingredients> getOtherIngredients()
        {
            throw new NotImplementedException();
        }

        public override Soup getSoup()
        {
            throw new NotImplementedException();
        }

        public override List<Vegetable> getVegetables()
        {
            throw new NotImplementedException();
        }
    }
}