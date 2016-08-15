using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator.Core
{
    public class RecipeCalculationResult
    {
        public string RecipeName { get; }
        public decimal Tax { get; }
        public decimal Discount { get; }
        public decimal Total { get; }

        public RecipeCalculationResult(string recipeName, decimal tax, decimal discount, decimal total)
        {
            RecipeName = recipeName;
            Tax = tax;
            Discount = discount;
            Total = total;
        }
    }
}
