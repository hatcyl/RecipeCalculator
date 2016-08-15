using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator.Core
{
    public class Recipe
    {
        private const decimal SALES_TAX = 0.086m;
        private const decimal WELLNESS_DISCOUNT = 0.05m; 

        public string Name { get; }
        public IEnumerable<RecipeItem> RecipeItems { get; }

        public Recipe(string name, IEnumerable<RecipeItem> recipeItems)
        {
            Name = name;
            RecipeItems = recipeItems;
        }

        public RecipeCalculationResult GetRecipeCalculationResult()
        {
            decimal subTotal = 0;
            decimal wellnessSubTotal = 0;
            decimal taxableSubtotal = 0;

            foreach (var recipeItem in RecipeItems)
            {
                decimal recipeItemPrice = recipeItem.Ingridient.Price * recipeItem.Quantity;

                subTotal += recipeItemPrice;

                if (recipeItem.Ingridient.IsEligibleForWellnessDiscount)
                {
                    wellnessSubTotal += recipeItemPrice;
                }

                if(recipeItem.Ingridient.IsTaxable)
                {
                    taxableSubtotal += recipeItemPrice;
                }
            }

            //TODO: Refactor rounding logic.
            decimal tax = taxableSubtotal * SALES_TAX;
            decimal roundedTax = Math.Ceiling(tax / 0.07m) * 0.07m;
            tax = Decimal.Round(roundedTax, 2);

            decimal wellnessDiscount = wellnessSubTotal * WELLNESS_DISCOUNT;
            decimal roundedWellnessDiscount = Math.Ceiling(wellnessDiscount / 0.01m) * 0.01m;
            wellnessDiscount = Decimal.Round(roundedWellnessDiscount, 2);

            decimal total = subTotal + tax - wellnessDiscount;
            total = Decimal.Round(total, 2, MidpointRounding.AwayFromZero);

            return new RecipeCalculationResult(Name, tax, wellnessDiscount, total);
        }
    }
}
