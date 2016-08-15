namespace RecipeCalculator.Core
{
    public abstract class Ingredient
    {
        public abstract string Name { get; }

        public abstract decimal Price { get; }

        public bool IsEligibleForWellnessDiscount { get { return IsOrganic; } }

        public abstract bool IsTaxable { get; }

        public abstract bool IsOrganic { get; }
    }
}