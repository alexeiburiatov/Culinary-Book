
namespace Culinary_Book
{
    partial class SignUpForm
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
            this.loginLabelSignUpForm = new System.Windows.Forms.Label();
            this.fNameLabelSignUpForm = new System.Windows.Forms.Label();
            this.Прізвище = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLoginInput = new System.Windows.Forms.TextBox();
            this.textBoxFNameInput = new System.Windows.Forms.TextBox();
            this.textBoxLNameInput = new System.Windows.Forms.TextBox();
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.textBoxPasswordCheckInput = new System.Windows.Forms.TextBox();
            this.textBoxEmailInput = new System.Windows.Forms.TextBox();
            this.submitDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabelSignUpForm
            // 
            this.loginLabelSignUpForm.AutoSize = true;
            this.loginLabelSignUpForm.Font = new System.Drawing.Font("Constantia", 20F);
            this.loginLabelSignUpForm.Location = new System.Drawing.Point(171, 157);
            this.loginLabelSignUpForm.Name = "loginLabelSignUpForm";
            this.loginLabelSignUpForm.Size = new System.Drawing.Size(83, 33);
            this.loginLabelSignUpForm.TabIndex = 6;
            this.loginLabelSignUpForm.Text = "Login";
            this.loginLabelSignUpForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fNameLabelSignUpForm
            // 
            this.fNameLabelSignUpForm.AutoSize = true;
            this.fNameLabelSignUpForm.Font = new System.Drawing.Font("Constantia", 20F);
            this.fNameLabelSignUpForm.Location = new System.Drawing.Point(171, 201);
            this.fNameLabelSignUpForm.Name = "fNameLabelSignUpForm";
            this.fNameLabelSignUpForm.Size = new System.Drawing.Size(62, 33);
            this.fNameLabelSignUpForm.TabIndex = 7;
            this.fNameLabelSignUpForm.Text = "Ім’я";
            this.fNameLabelSignUpForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Прізвище
            // 
            this.Прізвище.AutoSize = true;
            this.Прізвище.Font = new System.Drawing.Font("Constantia", 20F);
            this.Прізвище.Location = new System.Drawing.Point(171, 244);
            this.Прізвище.Name = "Прізвище";
            this.Прізвище.Size = new System.Drawing.Size(135, 33);
            this.Прізвище.TabIndex = 8;
            this.Прізвище.Text = "Прізвище";
            this.Прізвище.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 20F);
            this.label2.Location = new System.Drawing.Point(171, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 20F);
            this.label3.Location = new System.Drawing.Point(171, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль повторно";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 20F);
            this.label4.Location = new System.Drawing.Point(171, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxLoginInput
            // 
            this.textBoxLoginInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxLoginInput.Location = new System.Drawing.Point(419, 157);
            this.textBoxLoginInput.Name = "textBoxLoginInput";
            this.textBoxLoginInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxLoginInput.TabIndex = 12;
            this.textBoxLoginInput.TextChanged += new System.EventHandler(this.textBoxLoginInput_TextChanged);
            // 
            // textBoxFNameInput
            // 
            this.textBoxFNameInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxFNameInput.Location = new System.Drawing.Point(419, 201);
            this.textBoxFNameInput.Name = "textBoxFNameInput";
            this.textBoxFNameInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxFNameInput.TabIndex = 13;
            this.textBoxFNameInput.TextChanged += new System.EventHandler(this.textBoxFNameInput_TextChanged);
            // 
            // textBoxLNameInput
            // 
            this.textBoxLNameInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxLNameInput.Location = new System.Drawing.Point(419, 244);
            this.textBoxLNameInput.Name = "textBoxLNameInput";
            this.textBoxLNameInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxLNameInput.TabIndex = 14;
            this.textBoxLNameInput.TextChanged += new System.EventHandler(this.textBoxLNameInput_TextChanged);
            // 
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxPasswordInput.Location = new System.Drawing.Point(419, 288);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxPasswordInput.TabIndex = 15;
            this.textBoxPasswordInput.UseSystemPasswordChar = true;
            this.textBoxPasswordInput.TextChanged += new System.EventHandler(this.textBoxPasswordInput_TextChanged);
            // 
            // textBoxPasswordCheckInput
            // 
            this.textBoxPasswordCheckInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxPasswordCheckInput.Location = new System.Drawing.Point(419, 335);
            this.textBoxPasswordCheckInput.Name = "textBoxPasswordCheckInput";
            this.textBoxPasswordCheckInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxPasswordCheckInput.TabIndex = 16;
            this.textBoxPasswordCheckInput.UseSystemPasswordChar = true;
            this.textBoxPasswordCheckInput.TextChanged += new System.EventHandler(this.textBoxPasswordCheckInput_TextChanged);
            // 
            // textBoxEmailInput
            // 
            this.textBoxEmailInput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxEmailInput.Location = new System.Drawing.Point(419, 382);
            this.textBoxEmailInput.Name = "textBoxEmailInput";
            this.textBoxEmailInput.Size = new System.Drawing.Size(172, 30);
            this.textBoxEmailInput.TabIndex = 17;
            this.textBoxEmailInput.TextChanged += new System.EventHandler(this.textBoxEmailInput_TextChanged);
            // 
            // submitDataButton
            // 
            this.submitDataButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.submitDataButton.Location = new System.Drawing.Point(655, 435);
            this.submitDataButton.Name = "submitDataButton";
            this.submitDataButton.Size = new System.Drawing.Size(106, 34);
            this.submitDataButton.TabIndex = 9;
            this.submitDataButton.Text = "Зареєструватися";
            this.submitDataButton.UseVisualStyleBackColor = true;
            this.submitDataButton.Click += new System.EventHandler(this.submitDataButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.submitDataButton);
            this.Controls.Add(this.textBoxEmailInput);
            this.Controls.Add(this.textBoxPasswordCheckInput);
            this.Controls.Add(this.textBoxPasswordInput);
            this.Controls.Add(this.textBoxLNameInput);
            this.Controls.Add(this.textBoxFNameInput);
            this.Controls.Add(this.textBoxLoginInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Прізвище);
            this.Controls.Add(this.fNameLabelSignUpForm);
            this.Controls.Add(this.loginLabelSignUpForm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 601);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 601);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabelSignUpForm;
        private System.Windows.Forms.Label fNameLabelSignUpForm;
        private System.Windows.Forms.Label Прізвище;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLoginInput;
        private System.Windows.Forms.TextBox textBoxFNameInput;
        private System.Windows.Forms.TextBox textBoxLNameInput;
        private System.Windows.Forms.TextBox textBoxPasswordInput;
        private System.Windows.Forms.TextBox textBoxPasswordCheckInput;
        private System.Windows.Forms.TextBox textBoxEmailInput;
        private System.Windows.Forms.Button submitDataButton;
    }
}