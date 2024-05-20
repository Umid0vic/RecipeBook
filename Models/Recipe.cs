namespace RecipeBook.Models;

public class Recipe
{
    // Fields
    private string name;
    private string description;
    private string[] ingredients;
    private FoodCategory category;
    private int maxNumOfIngredients;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string[] Ingredients
    {
        get { return ingredients; }
        set { ingredients = value; }
    }

    public FoodCategory Category
    {
        get { return category; }
        set { category = value; }
    }

    public int MaxNumOfIngredients
    {
        get { return maxNumOfIngredients; }
        private set { maxNumOfIngredients = value; }
    }

    // Constructor
    public Recipe(int maxNumOfIngredients)
    {
        this.maxNumOfIngredients = maxNumOfIngredients;
        this.ingredients = new string[maxNumOfIngredients];
    }

    // Methods
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

    public bool ChangeIngredientAt(int index, string newIngredient)
    {
        if (index >= 0 && index < ingredients.Length && ingredients[index] != null)
        {
            ingredients[index] = newIngredient;
            return true;
        }

        return false;
    }

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

    private void MoveElementsOneStepToLeft(int index)
    {
        for (int i = index; i < ingredients.Length - 1; i++)
        {
            ingredients[i] = ingredients[i + 1];
        }

        ingredients[ingredients.Length - 1] = null;
    }

    public override string ToString()
    {
        return $"{Name} - {Category}";
    }
}