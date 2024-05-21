namespace RecipeBook
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxAddNewRecipe = new GroupBox();
            textBoxAddRecipe = new TextBox();
            buttonAddRecipe = new Button();
            buttonAddIngredients = new Button();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            textBoxRecipeName = new TextBox();
            labelRecipeName = new Label();
            listViewRecipes = new ListView();
            buttonEditBegin = new Button();
            buttonEditFinish = new Button();
            buttonDelete = new Button();
            buttonClearSelection = new Button();
            columnHeaderName = new ColumnHeader();
            columnHeaderCategory = new ColumnHeader();
            columnHeaderNumOfIngredients = new ColumnHeader();
            groupBoxAddNewRecipe.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddNewRecipe
            // 
            groupBoxAddNewRecipe.Controls.Add(textBoxAddRecipe);
            groupBoxAddNewRecipe.Controls.Add(buttonAddRecipe);
            groupBoxAddNewRecipe.Controls.Add(buttonAddIngredients);
            groupBoxAddNewRecipe.Controls.Add(comboBoxCategory);
            groupBoxAddNewRecipe.Controls.Add(labelCategory);
            groupBoxAddNewRecipe.Controls.Add(textBoxRecipeName);
            groupBoxAddNewRecipe.Controls.Add(labelRecipeName);
            groupBoxAddNewRecipe.Location = new Point(12, 12);
            groupBoxAddNewRecipe.Name = "groupBoxAddNewRecipe";
            groupBoxAddNewRecipe.Size = new Size(408, 426);
            groupBoxAddNewRecipe.TabIndex = 0;
            groupBoxAddNewRecipe.TabStop = false;
            groupBoxAddNewRecipe.Text = "Add new recipe";
            // 
            // textBoxAddRecipe
            // 
            textBoxAddRecipe.Location = new Point(6, 83);
            textBoxAddRecipe.Multiline = true;
            textBoxAddRecipe.Name = "textBoxAddRecipe";
            textBoxAddRecipe.Size = new Size(396, 304);
            textBoxAddRecipe.TabIndex = 8;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(6, 393);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(396, 23);
            buttonAddRecipe.TabIndex = 7;
            buttonAddRecipe.Text = "Add Recipe";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // buttonAddIngredients
            // 
            buttonAddIngredients.Location = new Point(250, 54);
            buttonAddIngredients.Name = "buttonAddIngredients";
            buttonAddIngredients.Size = new Size(152, 23);
            buttonAddIngredients.TabIndex = 4;
            buttonAddIngredients.Text = "Add Ingredients";
            buttonAddIngredients.UseVisualStyleBackColor = true;
            buttonAddIngredients.Click += buttonAddIngredients_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(100, 54);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(144, 23);
            comboBoxCategory.TabIndex = 3;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(6, 54);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(55, 15);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Category";
            // 
            // textBoxRecipeName
            // 
            textBoxRecipeName.Location = new Point(100, 25);
            textBoxRecipeName.Name = "textBoxRecipeName";
            textBoxRecipeName.Size = new Size(302, 23);
            textBoxRecipeName.TabIndex = 1;
            // 
            // labelRecipeName
            // 
            labelRecipeName.AutoSize = true;
            labelRecipeName.Location = new Point(6, 28);
            labelRecipeName.Name = "labelRecipeName";
            labelRecipeName.Size = new Size(88, 15);
            labelRecipeName.TabIndex = 0;
            labelRecipeName.Text = "Name of recipe";
            // 
            // listViewRecipes
            // 
            listViewRecipes.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderCategory, columnHeaderNumOfIngredients });
            listViewRecipes.FullRowSelect = true;
            listViewRecipes.GridLines = true;
            listViewRecipes.Location = new Point(426, 12);
            listViewRecipes.Name = "listViewRecipes";
            listViewRecipes.Size = new Size(452, 387);
            listViewRecipes.TabIndex = 6;
            listViewRecipes.UseCompatibleStateImageBehavior = false;
            listViewRecipes.View = View.Details;
            listViewRecipes.MouseDoubleClick += listViewRecipes_MouseDoubleClick;
            listViewRecipes.SelectedIndexChanged += listViewRecipes_SelectedIndexChanged;
            // 
            // buttonEditBegin
            // 
            buttonEditBegin.Location = new Point(426, 405);
            buttonEditBegin.Name = "buttonEditBegin";
            buttonEditBegin.Size = new Size(95, 23);
            buttonEditBegin.TabIndex = 10;
            buttonEditBegin.Text = "Edit-Begin";
            buttonEditBegin.UseVisualStyleBackColor = true;
            buttonEditBegin.Click += buttonEditBegin_Click;
            // 
            // buttonEditFinish
            // 
            buttonEditFinish.Location = new Point(551, 405);
            buttonEditFinish.Name = "buttonEditFinish";
            buttonEditFinish.Size = new Size(95, 23);
            buttonEditFinish.TabIndex = 11;
            buttonEditFinish.Text = "Edit-Finish";
            buttonEditFinish.UseVisualStyleBackColor = true;
            buttonEditFinish.Click += buttonEditFinish_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(676, 405);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 23);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClearSelection
            // 
            buttonClearSelection.Location = new Point(797, 405);
            buttonClearSelection.Name = "buttonClearSelection";
            buttonClearSelection.Size = new Size(95, 23);
            buttonClearSelection.TabIndex = 13;
            buttonClearSelection.Text = "Clear Selection";
            buttonClearSelection.UseVisualStyleBackColor = true;
            buttonClearSelection.Click += buttonClearSelection_Click;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 150;
            // 
            // columnHeaderCategory
            // 
            columnHeaderCategory.Text = "Category";
            columnHeaderCategory.Width = 150;
            // 
            // columnHeaderNumOfIngredients
            // 
            columnHeaderNumOfIngredients.Text = "Num of Ingredients";
            columnHeaderNumOfIngredients.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(buttonClearSelection);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEditFinish);
            Controls.Add(buttonEditBegin);
            Controls.Add(listViewRecipes);
            Controls.Add(groupBoxAddNewRecipe);
            Name = "MainForm";
            Text = "Apu Recipe Book By Osman";
            Load += MainForm_Load;
            groupBoxAddNewRecipe.ResumeLayout(false);
            groupBoxAddNewRecipe.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox groupBoxAddNewRecipe;
        private Label labelRecipeName;
        private TextBox textBoxRecipeName;
        private Button buttonAddIngredients;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private Button buttonAddRecipe;
        private TextBox textBoxAddRecipe;
        private ListView listViewRecipes;
        private Button buttonEditBegin;
        private Button buttonEditFinish;
        private Button buttonDelete;
        private Button buttonClearSelection;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderCategory;
        private ColumnHeader columnHeaderNumOfIngredients;
    }
}
