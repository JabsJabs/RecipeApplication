using RecipeApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    internal class Recepe
    {
    }
}
// Class to represent a recipe
class Recipe
{
    private Ingredient[] ingredients; // Array to store ingredients
    private Step[] steps;             // Array to store steps
    private double[] originalQuantities; // Array to store original quantities

    // Constructor to initialize the recipe with given number of ingredients and steps
    public Recipe(int numIngredients, int numSteps)
    {
        ingredients = new Ingredient[numIngredients];
        steps = new Step[numSteps];
        originalQuantities = new double[numIngredients];
    }

    // Method to allow user to enter ingredients for the recipe
    public void EnterIngredients()
    {
        Console.WriteLine("Enter ingredients:");
        for (int i = 0; i < ingredients.Length; i++)
        {
            Console.WriteLine($"Ingredient {i + 1}: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("Unit: ");
            string unit = Console.ReadLine();

            ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
            originalQuantities[i] = quantity; // Store original quantity
        }
    }

    // Method to allow user to enter steps for the recipe
    public void EnterSteps()
    {
        Console.WriteLine("\nEnter steps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"Step {i + 1}:");
            Console.Write("Description: ");
            string description = Console.ReadLine();

            steps[i] = new Step { Description = description };
        }
    }

    // Method to display the recipe
    public void DisplayRecipe()
    {
        Console.WriteLine("\nRecipe:");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }
        Console.WriteLine("\nSteps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i].Description}");
        }
    }

    // Method to scale the recipe by a given factor
    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    // Method to reset ingredient quantities to original values
    public void ResetQuantities()
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            ingredients[i].Quantity = originalQuantities[i];
        }
    }

    // Method to clear all data in the recipe
    public void ClearRecipe()
    {
        // Clear all data
        ingredients = new Ingredient[ingredients.Length];
        steps = new Step[steps.Length];
    }
}
