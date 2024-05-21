using System;
using System.Windows.Forms;
using RecipeBook.Models;

namespace RecipeBook
{
    public partial class IngredientsForm : Form
    {
        private Recipe currRecipe;

        /// <summary>
        /// Initializes a new instance of the IngredientsForm class.
        /// </summary>
        /// <param name="recipe">The recipe to manage ingredients for.</param>
        public IngredientsForm(Recipe recipe)
        {
            InitializeComponent();
            currRecipe = recipe;
            UpdateIngredientsList();
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddIngredient.Text))
            {
                if (currRecipe.AddIngredient(textBoxAddIngredient.Text))
                {
                    UpdateIngredientsList();
                    textBoxAddIngredient.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add ingredient. The ingredient list might be full.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.");
            }
        }

        private void buttonEditIngredients_Click(object sender, EventArgs e)
        {
            if (listBoxCurrentIngredients.SelectedIndex >= 0)
            {
                string newIngredient = textBoxAddIngredient.Text;
                if (!string.IsNullOrWhiteSpace(newIngredient))
                {
                    currRecipe.ChangeIngredientAt(listBoxCurrentIngredients.SelectedIndex, newIngredient);
                    UpdateIngredientsList();
                    textBoxAddIngredient.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a new ingredient.");
                }
            }
            else
            {
                MessageBox.Show("Please select an ingredient to edit.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxCurrentIngredients.SelectedIndex >= 0)
            {
                currRecipe.DeleteIngredientAt(listBoxCurrentIngredients.SelectedIndex);
                UpdateIngredientsList();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to delete.");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Updates the list of ingredients.
        /// </summary>
        private void UpdateIngredientsList()
        {
            listBoxCurrentIngredients.Items.Clear();
            foreach (var ingredient in currRecipe.Ingredients)
            {
                if (ingredient != null)
                {
                    listBoxCurrentIngredients.Items.Add(ingredient);
                }
            }

            labelNumOfIngredients.Text = $"Num of Ingredients: {currRecipe.CurrentNumberOfIngredients()}";
        }
    }
}