
namespace Culinary_Book
{
    partial class NoteSheet
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
            this.saveButton = new System.Windows.Forms.Button();
            this.recipeTextBox = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginLabelForm1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.saveButton.Location = new System.Drawing.Point(219, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 31);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // recipeTextBox
            // 
            this.recipeTextBox.Font = new System.Drawing.Font("Constantia", 14F);
            this.recipeTextBox.Location = new System.Drawing.Point(12, 78);
            this.recipeTextBox.Name = "recipeTextBox";
            this.recipeTextBox.Size = new System.Drawing.Size(976, 471);
            this.recipeTextBox.TabIndex = 10;
            this.recipeTextBox.Text = "";
            this.recipeTextBox.TextChanged += new System.EventHandler(this.recipeTextBox_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.exitButton.Location = new System.Drawing.Point(890, 25);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 31);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Повернутися";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginLabelForm1
            // 
            this.loginLabelForm1.AutoSize = true;
            this.loginLabelForm1.Font = new System.Drawing.Font("Constantia", 20F);
            this.loginLabelForm1.Location = new System.Drawing.Point(25, 23);
            this.loginLabelForm1.Name = "loginLabelForm1";
            this.loginLabelForm1.Size = new System.Drawing.Size(167, 33);
            this.loginLabelForm1.TabIndex = 13;
            this.loginLabelForm1.Text = "Мої нотатки";
            this.loginLabelForm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoteSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 561);
            this.Controls.Add(this.loginLabelForm1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.recipeTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 600);
            this.Name = "NoteSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NoteSheet";
            this.Load += new System.EventHandler(this.NoteSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox recipeTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label loginLabelForm1;
    }
}