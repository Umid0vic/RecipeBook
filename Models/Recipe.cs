namespace RecipeBook.Models;

/// <summary>
/// Class representing a recipe.
/// </summary>
public class Recipe
{
    // Fields
    private string name;
    private string description;
    private string[] ingredients;
    private FoodCategory category;
    private int maxNumOfIngredients;

    /// <summary>
    /// Gets or sets the name of the recipe.
    /// </summary>
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    /// <summary>
    /// Gets or sets the description of the recipe.
    /// </summary>
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    /// <summary>
    /// Gets or sets the ingredients of the recipe.
    /// </summary>
    public string[] Ingredients
    {
        get { return ingredients; }
        set { ingredients = value; }
    }

    /// <summary>
    /// Gets or sets the category of the recipe.
    /// </summary>
    public FoodCategory Category
    {
        get { return category; }
        set { category = value; }
    }

    /// <summary>
    /// Gets the maximum number of ingredients.
    /// </summary>
    public int MaxNumOfIngredients
    {
        get { return maxNumOfIngredients; }
        private set { maxNumOfIngredients = value; }
    }

    /// <summary>
    /// Initializes a new instance of the Recipe class.
    /// </summary>
    /// <param name="maxNumOfIngredients">The maximum number of ingredients.</param>
    public Recipe(int maxNumOfIngredients)
    {
        this.maxNumOfIngredients = maxNumOfIngredients;
        this.ingredients = new string[maxNumOfIngredients];
    }

    /// <summary>
    /// Adds an ingredient to the recipe.
    /// </summary>
    /// <param name="ingredient">The ingredient to add.</param>
    /// <returns>True if the ingredient was added; otherwise, false.</returns>
    public bool AddIngredient(string ingredient)
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i] == null)
            {
                ingredients[i] = ingredient;
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Changes an ingredient at the specified index.
    /// </summary>
    /// <param name="index">The index of the ingredient to change.</param>
    /// <param name="newIngredient">The new ingredient.</param>
    /// <returns>True if the ingredient was changed; otherwise, false.</returns>
    public bool ChangeIngredientAt(int index, string newIngredient)
    {
        if (index >= 0 && index < ingredients.Length && ingredients[index] != null)
        {
            ingredients[index] = newIngredient;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Deletes an ingredient at the specified index.
    /// </summary>
    /// <param name="index">The index of the ingredient to delete.</param>
    /// <returns>True if the ingredient was deleted; otherwise, false.</returns>
    public bool DeleteIngredientAt(int index)
    {
        if (index >= 0 && index < ingredients.Length && ingredients[index] != null)
        {
            ingredients[index] = null;
            MoveElementsOneStepToLeft(index);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Gets the current number of ingredients.
    /// </summary>
    /// <returns>The current number of ingredients.</returns>
    public int CurrentNumberOfIngredients()
    {
        int count = 0;
        foreach (var ingredient in ingredients)
        {
            if (ingredient != null)
                count++;
        }

        return count;
    }

    /// <summary>
    /// Moves the elements one step to the left starting from the specified index.
    /// </summary>
    /// <param name="index">The index to start moving from.</param>
    private void MoveElementsOneStepToLeft(int index)
    {
        for (int i = index; i < ingredients.Length - 1; i++)
        {
            ingredients[i] = ingredients[i + 1];
        }

        ingredients[ingredients.Length - 1] = null;
    }

    /// <summary>
    /// Returns a string representation of the recipe.
    /// </summary>
    /// <returns>A string representing the recipe.</returns>
    public override string ToString()
    {
        return $"{Name} - {Category}";
    }
}