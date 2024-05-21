namespace RecipeBook
{
    partial class IngredientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNumOfIngredients = new Label();
            groupBoxIngredients = new GroupBox();
            buttonDelete = new Button();
            buttonEditIngredients = new Button();
            buttonAddIngredient = new Button();
            listBoxCurrentIngredients = new ListBox();
            textBoxAddIngredient = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            groupBoxIngredients.SuspendLayout();
            SuspendLayout();
            // 
            // labelNumOfIngredients
            // 
            labelNumOfIngredients.AutoSize = true;
            labelNumOfIngredients.Location = new Point(12, 19);
            labelNumOfIngredients.Name = "labelNumOfIngredients";
            labelNumOfIngredients.Size = new Size(116, 15);
            labelNumOfIngredients.TabIndex = 0;
            labelNumOfIngredients.Text = "Num of Ingredients: ";
            // 
            // groupBoxIngredients
            // 
            groupBoxIngredients.Controls.Add(buttonDelete);
            groupBoxIngredients.Controls.Add(buttonEditIngredients);
            groupBoxIngredients.Controls.Add(buttonAddIngredient);
            groupBoxIngredients.Controls.Add(listBoxCurrentIngredients);
            groupBoxIngredients.Controls.Add(textBoxAddIngredient);
            groupBoxIngredients.Location = new Point(12, 37);
            groupBoxIngredients.Name = "groupBoxIngredients";
            groupBoxIngredients.Size = new Size(449, 360);
            groupBoxIngredients.TabIndex = 1;
            groupBoxIngredients.TabStop = false;
            groupBoxIngredients.Text = "Ingredients";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(350, 80);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(93, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEditIngredients
            // 
            buttonEditIngredients.Location = new Point(350, 51);
            buttonEditIngredients.Name = "buttonEditIngredients";
            buttonEditIngredients.Size = new Size(93, 23);
            buttonEditIngredients.TabIndex = 3;
            buttonEditIngredients.Text = "Edit";
            buttonEditIngredients.UseVisualStyleBackColor = true;
            // 
            // buttonAddIngredient
            // 
            buttonAddIngredient.Location = new Point(350, 22);
            buttonAddIngredient.Name = "buttonAddIngredient";
            buttonAddIngredient.Size = new Size(93, 23);
            buttonAddIngredient.TabIndex = 2;
            buttonAddIngredient.Text = "Add";
            buttonAddIngredient.UseVisualStyleBackColor = true;
            // 
            // listBoxCurrentIngredients
            // 
            listBoxCurrentIngredients.FormattingEnabled = true;
            listBoxCurrentIngredients.ItemHeight = 15;
            listBoxCurrentIngredients.Location = new Point(6, 51);
            listBoxCurrentIngredients.Name = "listBoxCurrentIngredients";
            listBoxCurrentIngredients.Size = new Size(338, 304);
            listBoxCurrentIngredients.TabIndex = 1;
            // 
            // textBoxAddIngredient
            // 
            textBoxAddIngredient.Location = new Point(6, 22);
            textBoxAddIngredient.Name = "textBoxAddIngredient";
            textBoxAddIngredient.Size = new Size(338, 23);
            textBoxAddIngredient.TabIndex = 0;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(76, 403);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(93, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(185, 403);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(93, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(groupBoxIngredients);
            Controls.Add(labelNumOfIngredients);
            Name = "IngredientsForm";
            Text = "IngredientsForm";
            groupBoxIngredients.ResumeLayout(false);
            groupBoxIngredients.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            // Add event handlers
            buttonAddIngredient.Click += new EventHandler(this.buttonAddIngredient_Click);
            buttonEditIngredients.Click += new EventHandler(this.buttonEditIngredients_Click);
            buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
            buttonOk.Click += new EventHandler(this.buttonOk_Click);
            buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
        }

        #endregion

        private Label labelNumOfIngredients;
        private GroupBox groupBoxIngredients;
        private Button buttonDelete;
        private Button buttonEditIngredients;
        private Button buttonAddIngredient;
        private ListBox listBoxCurrentIngredients;
        private TextBox textBoxAddIngredient;
        private Button buttonOk;
        private Button buttonCancel;
    }
}