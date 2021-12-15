using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }

        private void headerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
