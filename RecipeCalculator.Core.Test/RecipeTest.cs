using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RecipeCalculator.Core.Test
{
    [TestClass]
    public class RecipeTest
    {
        [TestMethod]
        public void Recipe1Test()
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

            Assert.AreEqual("Recipe 1", recipeCost.RecipeName);
            Assert.AreEqual(0.21m, recipeCost.Tax);
            Assert.AreEqual(0.11m, recipeCost.Discount);
            Assert.AreEqual(4.45m, recipeCost.Total);
        }

        [TestMethod]
        public void Recipe2Test()
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

            Assert.AreEqual("Recipe 2", recipeCost.RecipeName);
            Assert.AreEqual(0.91m, recipeCost.Tax);
            Assert.AreEqual(0.09m, recipeCost.Discount);
            Assert.AreEqual(11.84m, recipeCost.Total);
        }

        [TestMethod]
        public void Recipe3Test()
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

            Assert.AreEqual("Recipe 3", recipeCost.RecipeName);
            Assert.AreEqual(0.42m, recipeCost.Tax);
            Assert.AreEqual(0.07m, recipeCost.Discount);
            Assert.AreEqual(8.91m, recipeCost.Total);
        }
    }
}
