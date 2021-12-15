
namespace Culinary_Book
{
    partial class NewRecipe
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
            this.recipeTextBox = new System.Windows.Forms.RichTextBox();
            this.ingredientsTextBox = new System.Windows.Forms.RichTextBox();
            this.headerTextBox = new System.Windows.Forms.RichTextBox();
            this.loginLabelForm1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.createRecipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recipeTextBox
            // 
            this.recipeTextBox.Font = new System.Drawing.Font("Constantia", 10F);
            this.recipeTextBox.Location = new System.Drawing.Point(12, 149);
            this.recipeTextBox.Name = "recipeTextBox";
            this.recipeTextBox.Size = new System.Drawing.Size(976, 368);
            this.recipeTextBox.TabIndex = 1;
            this.recipeTextBox.Text = "";
            this.recipeTextBox.TextChanged += new System.EventHandler(this.recipeTextBox_TextChanged);
            // 
            // ingredientsTextBox
            // 
            this.ingredientsTextBox.Font = new System.Drawing.Font("Constantia", 10F);
            this.ingredientsTextBox.Location = new System.Drawing.Point(173, 85);
            this.ingredientsTextBox.Name = "ingredientsTextBox";
            this.ingredientsTextBox.Size = new System.Drawing.Size(815, 58);
            this.ingredientsTextBox.TabIndex = 2;
            this.ingredientsTextBox.Text = "";
            this.ingredientsTextBox.TextChanged += new System.EventHandler(this.ingredientsTextBox_TextChanged);
            // 
            // headerTextBox
            // 
            this.headerTextBox.Font = new System.Drawing.Font("Constantia", 14F);
            this.headerTextBox.Location = new System.Drawing.Point(173, 31);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(815, 33);
            this.headerTextBox.TabIndex = 3;
            this.headerTextBox.Text = "";
            this.headerTextBox.TextChanged += new System.EventHandler(this.headerTextBox_TextChanged);
            // 
            // loginLabelForm1
            // 
            this.loginLabelForm1.AutoSize = true;
            this.loginLabelForm1.Font = new System.Drawing.Font("Constantia", 20F);
            this.loginLabelForm1.Location = new System.Drawing.Point(12, 31);
            this.loginLabelForm1.Name = "loginLabelForm1";
            this.loginLabelForm1.Size = new System.Drawing.Size(140, 33);
            this.loginLabelForm1.TabIndex = 6;
            this.loginLabelForm1.Text = "Заголовок";
            this.loginLabelForm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20F);
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Інгредієнти";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14F);
            this.label2.Location = new System.Drawing.Point(23, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Додати фото";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.addPhotoButton.Location = new System.Drawing.Point(143, 518);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(98, 31);
            this.addPhotoButton.TabIndex = 9;
            this.addPhotoButton.Text = "Вибрати";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // createRecipeButton
            // 
            this.createRecipeButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.createRecipeButton.Location = new System.Drawing.Point(889, 518);
            this.createRecipeButton.Name = "createRecipeButton";
            this.createRecipeButton.Size = new System.Drawing.Size(98, 31);
            this.createRecipeButton.TabIndex = 10;
            this.createRecipeButton.Text = "Створити";
            this.createRecipeButton.UseVisualStyleBackColor = true;
            this.createRecipeButton.Click += new System.EventHandler(this.createRecipeButton_Click);
            // 
            // NewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 561);
            this.Controls.Add(this.createRecipeButton);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabelForm1);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.ingredientsTextBox);
            this.Controls.Add(this.recipeTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 600);
            this.Name = "NewRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox recipeTextBox;
        private System.Windows.Forms.RichTextBox ingredientsTextBox;
        private System.Windows.Forms.RichTextBox headerTextBox;
        private System.Windows.Forms.Label loginLabelForm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Button createRecipeButton;
    }
}