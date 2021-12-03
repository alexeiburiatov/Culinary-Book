
namespace Culinary_Book
{
    partial class CulinaryBook
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
            this.textBoxLoginInput = new System.Windows.Forms.TextBox();
            this.welcomeLabelForm1 = new System.Windows.Forms.Label();
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.loginLabelForm1 = new System.Windows.Forms.Label();
            this.passwordLabelForm1 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLoginInput
            // 
            this.textBoxLoginInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxLoginInput.Location = new System.Drawing.Point(400, 207);
            this.textBoxLoginInput.Name = "textBoxLoginInput";
            this.textBoxLoginInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxLoginInput.TabIndex = 2;
            this.textBoxLoginInput.TextChanged += new System.EventHandler(this.textBoxLoginInput_TextChanged);
            // 
            // welcomeLabelForm1
            // 
            this.welcomeLabelForm1.AutoSize = true;
            this.welcomeLabelForm1.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabelForm1.Location = new System.Drawing.Point(215, 9);
            this.welcomeLabelForm1.Name = "welcomeLabelForm1";
            this.welcomeLabelForm1.Size = new System.Drawing.Size(644, 59);
            this.welcomeLabelForm1.TabIndex = 3;
            this.welcomeLabelForm1.Text = "Вітаємо в \"Кулінарній книзі\"";
            this.welcomeLabelForm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxPasswordInput.Location = new System.Drawing.Point(400, 299);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxPasswordInput.TabIndex = 4;
            this.textBoxPasswordInput.UseSystemPasswordChar = true;
            this.textBoxPasswordInput.TextChanged += new System.EventHandler(this.textBoxPasswordInput_TextChanged);
            // 
            // loginLabelForm1
            // 
            this.loginLabelForm1.AutoSize = true;
            this.loginLabelForm1.Font = new System.Drawing.Font("Constantia", 20F);
            this.loginLabelForm1.Location = new System.Drawing.Point(445, 171);
            this.loginLabelForm1.Name = "loginLabelForm1";
            this.loginLabelForm1.Size = new System.Drawing.Size(83, 33);
            this.loginLabelForm1.TabIndex = 5;
            this.loginLabelForm1.Text = "Login";
            this.loginLabelForm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordLabelForm1
            // 
            this.passwordLabelForm1.AutoSize = true;
            this.passwordLabelForm1.Font = new System.Drawing.Font("Constantia", 20F);
            this.passwordLabelForm1.Location = new System.Drawing.Point(421, 263);
            this.passwordLabelForm1.Name = "passwordLabelForm1";
            this.passwordLabelForm1.Size = new System.Drawing.Size(125, 33);
            this.passwordLabelForm1.TabIndex = 6;
            this.passwordLabelForm1.Text = "Password";
            this.passwordLabelForm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.logInButton.Location = new System.Drawing.Point(354, 359);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(106, 34);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Увійти";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.signUpButton.Location = new System.Drawing.Point(500, 359);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(106, 34);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Зареєструватися";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // CulinaryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordLabelForm1);
            this.Controls.Add(this.loginLabelForm1);
            this.Controls.Add(this.textBoxPasswordInput);
            this.Controls.Add(this.welcomeLabelForm1);
            this.Controls.Add(this.textBoxLoginInput);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 601);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 601);
            this.Name = "CulinaryBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Culinary Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLoginInput;
        private System.Windows.Forms.Label welcomeLabelForm1;
        private System.Windows.Forms.TextBox textBoxPasswordInput;
        private System.Windows.Forms.Label loginLabelForm1;
        private System.Windows.Forms.Label passwordLabelForm1;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button signUpButton;
    }
}

