using System;
using System.Text;
using System.Windows.Forms;
using RecipeBook.Models;

namespace RecipeBook
{
    public partial class MainForm : Form
    {
        private RecipeManager recipeManager;
        private Recipe currRecipe;
        private int editingIndex = -1;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            recipeManager = new RecipeManager(200); // Max 200 recipes
            comboBoxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            currRecipe = new Recipe(50); // Max 50 ingredients per recipe
            buttonDelete.Enabled = false; // Disable delete button initially
            buttonEditFinish.Enabled = false; // Disable Edit button initially
        }

        /// <summary>
        /// Handles the Load event of the MainForm.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            currRecipe = new Recipe(50); // Reset current recipe
        }

        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            IngredientsForm ingredientsForm = new IngredientsForm(currRecipe);
            ingredientsForm.ShowDialog();
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBoxRecipeName.Text)
                || comboBoxCategory.SelectedItem == null
                || currRecipe.CurrentNumberOfIngredients() == 0)
            {
                MessageBox.Show("Please fill all the fields and add at least one ingredient.");
                return;
            }

            currRecipe.Name = textBoxRecipeName.Text;
            currRecipe.Description = textBoxAddRecipe.Text;
            currRecipe.Category = (FoodCategory)comboBoxCategory.SelectedItem;

            if (editingIndex == -1) // Add new recipe
            {
                if (recipeManager.Add(currRecipe))
                {
                    UpdateRecipeList();
                    ClearInputs();
                    currRecipe = new Recipe(50); // Reset current recipe
                }
                else
                {
                    MessageBox.Show("Failed to add recipe. The recipe list might be full.");
                }
            }
            else // Update existing recipe
            {
                if (recipeManager.ChangeElement(editingIndex, currRecipe))
                {
                    UpdateRecipeList();
                    ClearInputs();
                    editingIndex = -1;
                    currRecipe = new Recipe(50); // Reset current recipe
                    buttonEditFinish.Enabled = false;
                    buttonEditBegin.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed to update recipe.");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewRecipes.SelectedIndices.Count > 0)
            {
                recipeManager.DeleteElement(listViewRecipes.SelectedIndices[0]);
                UpdateRecipeList();
            }
            else
            {
                MessageBox.Show("Please select a recipe to delete.");
            }
        }

        private void buttonClearSelection_Click(object sender, EventArgs e)
        {
            listViewRecipes.SelectedIndices.Clear();
        }


        /// <summary>
        /// Handles the MouseDoubleClick event of the listViewRecipes ListView.
        /// </summary>
        private void listViewRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewRecipes.SelectedIndices.Count > 0)
            {
                int index = listViewRecipes.SelectedIndices[0];
                Recipe selectedRecipe = recipeManager.GetRecipe(index);

                // Format the message to include both ingredients and description
                StringBuilder message = new StringBuilder();
                message.AppendLine("Ingredients:");
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    if (!string.IsNullOrEmpty(ingredient))
                    {
                        message.AppendLine(ingredient);
                    }
                }

                message.AppendLine();
                message.AppendLine("Description:");
                message.AppendLine(selectedRecipe.Description);

                MessageBox.Show(message.ToString(),
                    $"Details for {selectedRecipe.Name}",
                    MessageBoxButtons.OK); // No icon specified here
            }
        }

        private void buttonEditBegin_Click(object sender, EventArgs e)
        {
            if (listViewRecipes.SelectedIndices.Count > 0)
            {
                editingIndex = listViewRecipes.SelectedIndices[0];
                currRecipe = recipeManager.GetRecipe(editingIndex);

                textBoxRecipeName.Text = currRecipe.Name;
                textBoxAddRecipe.Text = currRecipe.Description;
                comboBoxCategory.SelectedItem = currRecipe.Category;

                buttonEditFinish.Enabled = true;
                buttonEditBegin.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a recipe to edit.");
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listViewRecipes ListView.
        /// </summary>
        private void listViewRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = listViewRecipes.SelectedIndices.Count > 0;
        }

        private void buttonEditFinish_Click(object sender, EventArgs e)
        {
            buttonAddRecipe_Click(sender, e);
        }

        /// <summary>
        /// Updates the recipe list in the ListView.
        /// </summary>
        private void UpdateRecipeList()
        {
            listViewRecipes.Items.Clear();
            for (int i = 0; i < recipeManager.GetCurrentNumberOfRecipes(); i++)
            {
                var recipe = recipeManager.GetRecipe(i);
                string[] row =
                    { recipe.Name, recipe.Category.ToString(), recipe.CurrentNumberOfIngredients().ToString() };
                var listViewItem = new ListViewItem(row);
                listViewRecipes.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// Clears the input fields.
        /// </summary>
        private void ClearInputs()
        {
            textBoxRecipeName.Clear();
            textBoxAddRecipe.Clear();
            comboBoxCategory.SelectedIndex = -1;
        }
    }
}