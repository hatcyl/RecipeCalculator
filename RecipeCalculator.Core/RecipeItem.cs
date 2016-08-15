namespace RecipeCalculator.Core
{
    public class RecipeItem
    {
        public Ingredient Ingridient { get; }
        public decimal Quantity { get; }

        public RecipeItem(Ingredient ingredient, decimal quantity)
        {
            Ingridient = ingredient;
            Quantity = quantity;
        }
    }
}