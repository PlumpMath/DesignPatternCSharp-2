using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Factory
    {
        public abstract Soup getSoup();
        public abstract Protein getMain();
        public abstract List<Vegetable> getVegetables();
        public abstract List<Ingredients> getOtherIngredients();
    }
}
