using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culinary_Book
{
    public partial class RecipeDescription : Form
    {
        private Database.CookBookDB db;
        private static string usrLogin;
        private string recipeId;
        private string[] data;
        public RecipeDescription(Database.CookBookDB db, string login, string recipeId)
        {
            this.data = new string[3];
            this.recipeId = recipeId;
            this.db = db;
            usrLogin = login;
            this.data = db.getFullRecipe(recipeId);
            InitializeComponent();
            this.headerTextBox.Text = this.data[0];
            this.ingredientsTextBox.Text = this.data[1];
            this.recipeTextBox.Text = this.data[2];
        }

        private void RecipeDescription_Load(object sender, EventArgs e)
        {
            int recipeNum = db.getImageNum(this.recipeId);
            byte[][] previewText = new byte[recipeNum][];
            db.getImage(this.recipeId);

            int top = 125;
            int left = 820;
            for (int i = 0, cnt=1; i < recipeNum; i++, cnt++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Name = "photo"+cnt;
                button.Click += ButtonOnClick;
                button.Height = 33;
                button.Width = 157;
                button.Text = "Фото " + cnt;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Font = new Font("Constantia", 8.25f);


                this.Controls.Add(button);
                top += button.Height + 2;
            }
        }


        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
               Process.Start("C:\\tmp\\"+button.Name+".png");

            }
        }


        private void returnButton_Click(object sender, EventArgs e)
        {

        }

        private void recipeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredientsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentsButton_Click(object sender, EventArgs e)
        {
            Comments comments = new Comments(db, usrLogin,recipeId);
            comments.ShowDialog();
        }

        private void headerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
