using RecipeCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator.ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Recipe1();
            Console.WriteLine();
            Recipe2();
            Console.WriteLine();
            Recipe3();
            Console.ReadLine();
        }

        public static void Recipe1()
        {
            IEnumerable<RecipeItem> recipeItems = new[]
            {
                new RecipeItem(new ProduceIngredient("Garlic", true, 0.67m), 1),
                new RecipeItem(new ProduceIngredient("Lemon", false, 2.03m), 1),
                new RecipeItem(new PantryIngredient("Olive Oil", true, 1.92m), 0.75m),
                new RecipeItem(new PantryIngredient("Salt", false, 0.16m), 0.75m),
                new RecipeItem(new PantryIngredient("Pepper", false, 0.17m), 0.50m)
            };

            Recipe recipe = new Recipe("Recipe 1", recipeItems);
            var recipeCost = recipe.GetRecipeCalculationResult();

            WriteToConsole(recipeCost);
        }

        public static void Recipe2()
        {
            IEnumerable<RecipeItem> recipeItems = new[]
            {
                new RecipeItem(new ProduceIngredient("Garlic", true, 0.67m), 1),
                new RecipeItem(new MeatPoultryIngredient("Chicken", false, 2.19m), 4),
                new RecipeItem(new PantryIngredient("Olive Oil", true, 1.92m), 0.50m),
                new RecipeItem(new PantryIngredient("Vinegar", false, 1.26m), 0.50m)
            };

            Recipe recipe = new Recipe("Recipe 2", recipeItems);
            var recipeCost = recipe.GetRecipeCalculationResult();

            WriteToConsole(recipeCost);
        }

        public static void Recipe3()
        {
            IEnumerable<RecipeItem> recipeItems = new[]
            {
                new RecipeItem(new ProduceIngredient("Garlic", true, 0.67m), 1),
                new RecipeItem(new ProduceIngredient("Corn", false, 0.87m), 4),
                new RecipeItem(new MeatPoultryIngredient("Bacon", false, 0.24m), 4),
                new RecipeItem(new PantryIngredient("Pasta", false, 0.31m), 8),
                new RecipeItem(new PantryIngredient("Olive Oil", true, 1.92m), 0.333m),
                new RecipeItem(new PantryIngredient("Salt", false, 0.16m), 1.25m),
                new RecipeItem(new PantryIngredient("Pepper", false, 0.17m), 0.75m)
            };

            Recipe recipe = new Recipe("Recipe 3", recipeItems);
            var recipeCost = recipe.GetRecipeCalculationResult();

            WriteToConsole(recipeCost);
        }

        public static void WriteToConsole(RecipeCalculationResult recipeCalculationResult)
        {
            Console.WriteLine("{0}", recipeCalculationResult.RecipeName);
            Console.WriteLine("Tax = ${0}", recipeCalculationResult.Tax);
            Console.WriteLine("Discount = (${0})", recipeCalculationResult.Discount);
            Console.WriteLine("Total = ${0}", recipeCalculationResult.Total);
        }
    }
}
