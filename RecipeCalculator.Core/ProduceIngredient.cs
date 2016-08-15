using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator.Core
{
    public class ProduceIngredient : Ingredient
    {
        public override string Name { get; }

        public override bool IsOrganic { get; }

        public override bool IsTaxable { get { return false; } }

        public override decimal Price { get; }

        public ProduceIngredient(string name, bool isOrganic, decimal price)
        {
            Name = name;
            IsOrganic = isOrganic;
            Price = price;
        }
    }
}
