
namespace Culinary_Book
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Прізвище = new System.Windows.Forms.Label();
            this.fNameLabelSignUpForm = new System.Windows.Forms.Label();
            this.welcomeLabelForm1 = new System.Windows.Forms.Label();
            this.textBoxEmailOutput = new System.Windows.Forms.TextBox();
            this.textBoxLNameOutput = new System.Windows.Forms.TextBox();
            this.textBoxFNameOutput = new System.Windows.Forms.TextBox();
            this.textBoxLoginOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRecipe,
            this.ShowAllRecipe,
            this.ShowNotes,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddRecipe
            // 
            this.AddRecipe.Name = "AddRecipe";
            this.AddRecipe.Size = new System.Drawing.Size(99, 20);
            this.AddRecipe.Text = "Додати рецепт";
            this.AddRecipe.Click += new System.EventHandler(this.AddRecipe_Click);
            // 
            // ShowAllRecipe
            // 
            this.ShowAllRecipe.Name = "ShowAllRecipe";
            this.ShowAllRecipe.Size = new System.Drawing.Size(138, 20);
            this.ShowAllRecipe.Text = "Переглянути рецепти";
            this.ShowAllRecipe.Click += new System.EventHandler(this.ShowAllRecipe_Click);
            // 
            // ShowNotes
            // 
            this.ShowNotes.Name = "ShowNotes";
            this.ShowNotes.Size = new System.Drawing.Size(64, 20);
            this.ShowNotes.Text = "Нотатки";
            this.ShowNotes.Click += new System.EventHandler(this.нотаткиToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 20);
            this.Exit.Text = "Вийти";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20F);
            this.label1.Location = new System.Drawing.Point(55, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 20F);
            this.label4.Location = new System.Drawing.Point(55, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Прізвище
            // 
            this.Прізвище.AutoSize = true;
            this.Прізвище.Font = new System.Drawing.Font("Constantia", 20F);
            this.Прізвище.Location = new System.Drawing.Point(55, 259);
            this.Прізвище.Name = "Прізвище";
            this.Прізвище.Size = new System.Drawing.Size(135, 33);
            this.Прізвище.TabIndex = 20;
            this.Прізвище.Text = "Прізвище";
            this.Прізвище.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fNameLabelSignUpForm
            // 
            this.fNameLabelSignUpForm.AutoSize = true;
            this.fNameLabelSignUpForm.Font = new System.Drawing.Font("Constantia", 20F);
            this.fNameLabelSignUpForm.Location = new System.Drawing.Point(55, 216);
            this.fNameLabelSignUpForm.Name = "fNameLabelSignUpForm";
            this.fNameLabelSignUpForm.Size = new System.Drawing.Size(62, 33);
            this.fNameLabelSignUpForm.TabIndex = 19;
            this.fNameLabelSignUpForm.Text = "Ім’я";
            this.fNameLabelSignUpForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // welcomeLabelForm1
            // 
            this.welcomeLabelForm1.AutoSize = true;
            this.welcomeLabelForm1.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabelForm1.Location = new System.Drawing.Point(191, 55);
            this.welcomeLabelForm1.Name = "welcomeLabelForm1";
            this.welcomeLabelForm1.Size = new System.Drawing.Size(574, 59);
            this.welcomeLabelForm1.TabIndex = 22;
            this.welcomeLabelForm1.Text = "Персональна інформація";
            this.welcomeLabelForm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEmailOutput
            // 
            this.textBoxEmailOutput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmailOutput.Enabled = false;
            this.textBoxEmailOutput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxEmailOutput.Location = new System.Drawing.Point(350, 303);
            this.textBoxEmailOutput.Name = "textBoxEmailOutput";
            this.textBoxEmailOutput.ReadOnly = true;
            this.textBoxEmailOutput.Size = new System.Drawing.Size(400, 30);
            this.textBoxEmailOutput.TabIndex = 26;
            this.textBoxEmailOutput.TextChanged += new System.EventHandler(this.textBoxEmailOutput_TextChanged);
            // 
            // textBoxLNameOutput
            // 
            this.textBoxLNameOutput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLNameOutput.Enabled = false;
            this.textBoxLNameOutput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxLNameOutput.Location = new System.Drawing.Point(350, 259);
            this.textBoxLNameOutput.Name = "textBoxLNameOutput";
            this.textBoxLNameOutput.ReadOnly = true;
            this.textBoxLNameOutput.Size = new System.Drawing.Size(400, 30);
            this.textBoxLNameOutput.TabIndex = 25;
            this.textBoxLNameOutput.TextChanged += new System.EventHandler(this.textBoxLNameOutput_TextChanged);
            // 
            // textBoxFNameOutput
            // 
            this.textBoxFNameOutput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFNameOutput.Enabled = false;
            this.textBoxFNameOutput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxFNameOutput.Location = new System.Drawing.Point(350, 216);
            this.textBoxFNameOutput.Name = "textBoxFNameOutput";
            this.textBoxFNameOutput.ReadOnly = true;
            this.textBoxFNameOutput.Size = new System.Drawing.Size(400, 30);
            this.textBoxFNameOutput.TabIndex = 24;
            this.textBoxFNameOutput.TextChanged += new System.EventHandler(this.textBoxFNameOutput_TextChanged);
            // 
            // textBoxLoginOutput
            // 
            this.textBoxLoginOutput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoginOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLoginOutput.Enabled = false;
            this.textBoxLoginOutput.Font = new System.Drawing.Font("Constantia", 14F);
            this.textBoxLoginOutput.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxLoginOutput.Location = new System.Drawing.Point(350, 172);
            this.textBoxLoginOutput.Name = "textBoxLoginOutput";
            this.textBoxLoginOutput.ReadOnly = true;
            this.textBoxLoginOutput.Size = new System.Drawing.Size(400, 30);
            this.textBoxLoginOutput.TabIndex = 23;
            this.textBoxLoginOutput.TextChanged += new System.EventHandler(this.textBoxLoginOutput_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.textBoxEmailOutput);
            this.Controls.Add(this.textBoxLNameOutput);
            this.Controls.Add(this.textBoxFNameOutput);
            this.Controls.Add(this.textBoxLoginOutput);
            this.Controls.Add(this.welcomeLabelForm1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Прізвище);
            this.Controls.Add(this.fNameLabelSignUpForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 601);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 601);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Персональна сторінка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddRecipe;
        private System.Windows.Forms.ToolStripMenuItem ShowAllRecipe;
        private System.Windows.Forms.ToolStripMenuItem ShowNotes;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Прізвище;
        private System.Windows.Forms.Label fNameLabelSignUpForm;
        private System.Windows.Forms.Label welcomeLabelForm1;
        private System.Windows.Forms.TextBox textBoxEmailOutput;
        private System.Windows.Forms.TextBox textBoxLNameOutput;
        private System.Windows.Forms.TextBox textBoxFNameOutput;
        private System.Windows.Forms.TextBox textBoxLoginOutput;
    }
}