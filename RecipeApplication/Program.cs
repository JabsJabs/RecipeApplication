using System;

namespace RecipeApplication
{

}

   
    class Program
    {
        static void Main()
        {
            Recipe recipe = new Recipe(3, 5);
            recipe.EnterIngredients();
            recipe.EnterSteps();
            recipe.DisplayRecipe();

            // Example of scaling the recipe
            recipe.ScaleRecipe(2);
            recipe.DisplayRecipe();

            // Example of resetting quantities
            recipe.ResetQuantities();
            recipe.DisplayRecipe();
        }
    }

