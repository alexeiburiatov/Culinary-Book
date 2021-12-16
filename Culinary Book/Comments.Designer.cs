
namespace Culinary_Book
{
    partial class Comments
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
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.sendCommButton = new System.Windows.Forms.Button();
            this.commentsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Constantia", 10F);
            this.messageBox.Location = new System.Drawing.Point(10, 380);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(453, 58);
            this.messageBox.TabIndex = 3;
            this.messageBox.Text = "";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // sendCommButton
            // 
            this.sendCommButton.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.sendCommButton.Location = new System.Drawing.Point(365, 343);
            this.sendCommButton.Name = "sendCommButton";
            this.sendCommButton.Size = new System.Drawing.Size(98, 31);
            this.sendCommButton.TabIndex = 11;
            this.sendCommButton.Text = "Відправити";
            this.sendCommButton.UseVisualStyleBackColor = true;
            this.sendCommButton.Click += new System.EventHandler(this.sendCommButton_Click);
            // 
            // commentsBox
            // 
            this.commentsBox.Font = new System.Drawing.Font("Constantia", 10F);
            this.commentsBox.Location = new System.Drawing.Point(12, 12);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.ReadOnly = true;
            this.commentsBox.Size = new System.Drawing.Size(453, 289);
            this.commentsBox.TabIndex = 11;
            this.commentsBox.Text = "";
            this.commentsBox.TextChanged += new System.EventHandler(this.commentsBox_TextChanged);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.commentsBox);
            this.Controls.Add(this.sendCommButton);
            this.Controls.Add(this.messageBox);
            this.Name = "Comments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button sendCommButton;
        private System.Windows.Forms.RichTextBox commentsBox;
    }
}