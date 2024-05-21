namespace RecipeBook.Models;

/// <summary>
/// Class representing the recipe manager.
/// </summary>
public class RecipeManager
{
    // Fields
    private Recipe[] recipeList;
    private int numOfElems;

    /// <summary>
    /// Initializes a new instance of the RecipeManager class.
    /// </summary>
    /// <param name="maxNumOfElements">The maximum number of recipes.</param>
    public RecipeManager(int maxNumOfElements)
    {
        recipeList = new Recipe[maxNumOfElements];
        numOfElems = 0;
    }

    /// <summary>
    /// Adds a recipe to the manager.
    /// </summary>
    /// <param name="recipe">The recipe to add.</param>
    /// <returns>True if the recipe was added; otherwise, false.</returns>
    public bool Add(Recipe recipe)
    {
        if (numOfElems < recipeList.Length)
        {
            recipeList[numOfElems] = recipe;
            numOfElems++;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Changes a recipe at the specified index.
    /// </summary>
    /// <param name="index">The index of the recipe to change.</param>
    /// <param name="newRecipe">The new recipe.</param>
    /// <returns>True if the recipe was changed; otherwise, false.</returns>
    public bool ChangeElement(int index, Recipe newRecipe)
    {
        if (index >= 0 && index < numOfElems)
        {
            recipeList[index] = newRecipe;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Deletes a recipe at the specified index.
    /// </summary>
    /// <param name="index">The index of the recipe to delete.</param>
    /// <returns>True if the recipe was deleted; otherwise, false.</returns>
    public bool DeleteElement(int index)
    {
        if (index >= 0 && index < numOfElems)
        {
            recipeList[index] = null;
            numOfElems--;
            MoveElementsOneStepToLeft(index);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Gets the current number of recipes.
    /// </summary>
    /// <returns>The current number of recipes.</returns>
    public int GetCurrentNumberOfRecipes()
    {
        return numOfElems;
    }

    /// <summary>
    /// Gets the recipe list as a string array.
    /// </summary>
    /// <returns>An array of recipe names.</returns>
    public string[] GetRecipeListAsString()
    {
        string[] recipeNames = new string[numOfElems];
        for (int i = 0; i < numOfElems; i++)
        {
            if (recipeList[i] != null)
            {
                recipeNames[i] = recipeList[i].ToString();
            }
        }

        return recipeNames;
    }

    /// <summary>
    /// Gets a recipe at the specified index.
    /// </summary>
    /// <param name="index">The index of the recipe to get.</param>
    /// <returns>The recipe at the specified index.</returns>
    public Recipe GetRecipe(int index)
    {
        if (index >= 0 && index < numOfElems)
        {
            return recipeList[index];
        }

        return null;
    }

    /// <summary>
    /// Moves the elements one step to the left starting from the specified index.
    /// </summary>
    /// <param name="index">The index to start moving from.</param>
    private void MoveElementsOneStepToLeft(int index)
    {
        for (int i = index; i < recipeList.Length - 1; i++)
        {
            recipeList[i] = recipeList[i + 1];
        }

        recipeList[recipeList.Length - 1] = null;
    }
}