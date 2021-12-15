
namespace Culinary_Book
{
    partial class RecipeDescription
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabelForm1 = new System.Windows.Forms.Label();
            this.headerTextBox = new System.Windows.Forms.RichTextBox();
            this.ingredientsTextBox = new System.Windows.Forms.RichTextBox();
            this.recipeTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.commentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20F);
            this.label1.Location = new System.Drawing.Point(592, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Інгредієнти";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginLabelForm1
            // 
            this.loginLabelForm1.AutoSize = true;
            this.loginLabelForm1.Font = new System.Drawing.Font("Constantia", 20F);
            this.loginLabelForm1.Location = new System.Drawing.Point(181, 40);
            this.loginLabelForm1.Name = "loginLabelForm1";
            this.loginLabelForm1.Size = new System.Drawing.Size(140, 33);
            this.loginLabelForm1.TabIndex = 11;
            this.loginLabelForm1.Text = "Заголовок";
            this.loginLabelForm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // headerTextBox
            // 
            this.headerTextBox.Font = new System.Drawing.Font("Constantia", 14F);
            this.headerTextBox.Location = new System.Drawing.Point(12, 76);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(524, 33);
            this.headerTextBox.TabIndex = 10;
            this.headerTextBox.Text = "";
            this.headerTextBox.TextChanged += new System.EventHandler(this.headerTextBox_TextChanged);
            // 
            // ingredientsTextBox
            // 
            this.ingredientsTextBox.Font = new System.Drawing.Font("Constantia", 10F);
            this.ingredientsTextBox.Location = new System.Drawing.Point(566, 125);
            this.ingredientsTextBox.Name = "ingredientsTextBox";
            this.ingredientsTextBox.Size = new System.Drawing.Size(220, 424);
            this.ingredientsTextBox.TabIndex = 9;
            this.ingredientsTextBox.Text = "";
            this.ingredientsTextBox.TextChanged += new System.EventHandler(this.ingredientsTextBox_TextChanged);
            // 
            // recipeTextBox
            // 
            this.recipeTextBox.Font = new System.Drawing.Font("Constantia", 10F);
            this.recipeTextBox.Location = new System.Drawing.Point(12, 125);
            this.recipeTextBox.Name = "recipeTextBox";
            this.recipeTextBox.Size = new System.Drawing.Size(524, 424);
            this.recipeTextBox.TabIndex = 8;
            this.recipeTextBox.Text = "";
            this.recipeTextBox.TextChanged += new System.EventHandler(this.recipeTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 20F);
            this.label2.Location = new System.Drawing.Point(825, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фотографії";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.returnButton.Location = new System.Drawing.Point(879, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(98, 31);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Повернутися";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // commentsButton
            // 
            this.commentsButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.commentsButton.Location = new System.Drawing.Point(755, 12);
            this.commentsButton.Name = "commentsButton";
            this.commentsButton.Size = new System.Drawing.Size(98, 31);
            this.commentsButton.TabIndex = 15;
            this.commentsButton.Text = "Коментувати";
            this.commentsButton.UseVisualStyleBackColor = true;
            this.commentsButton.Click += new System.EventHandler(this.commentsButton_Click);
            // 
            // RecipeDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 561);
            this.Controls.Add(this.commentsButton);
            this.Controls.Add(this.returnButton);
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
            this.Name = "RecipeDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RecipeDescription";
            this.Load += new System.EventHandler(this.RecipeDescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabelForm1;
        private System.Windows.Forms.RichTextBox headerTextBox;
        private System.Windows.Forms.RichTextBox ingredientsTextBox;
        private System.Windows.Forms.RichTextBox recipeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button commentsButton;
    }
}