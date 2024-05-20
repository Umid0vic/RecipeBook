namespace RecipeBook.Models;

public class RecipeManager
{
    // Fields
    private Recipe[] recipeList;
    private int numOfElems;

    // Constructor
    public RecipeManager(int maxNumOfElements)
    {
        recipeList = new Recipe[maxNumOfElements];
        numOfElems = 0;
    }

    // Methods
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

    public bool ChangeElement(int index, Recipe newRecipe)
    {
        if (index >= 0 && index < numOfElems)
        {
            recipeList[index] = newRecipe;
            return true;
        }

        return false;
    }

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

    public int GetCurrentNumberOfRecipes()
    {
        return numOfElems;
    }

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

    private void MoveElementsOneStepToLeft(int index)
    {
        for (int i = index; i < recipeList.Length - 1; i++)
        {
            recipeList[i] = recipeList[i + 1];
        }

        recipeList[recipeList.Length - 1] = null;
    }
}