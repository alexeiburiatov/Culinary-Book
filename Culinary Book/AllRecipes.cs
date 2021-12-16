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
    public partial class AllRecipes : Form
    {
        private Database.CookBookDB db;
        private static string usrLogin;
        public AllRecipes(Database.CookBookDB db, string login)
        {

            this.db = db;
            usrLogin = login;
            InitializeComponent();


        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {

                RecipeDescription recipeDescription = new RecipeDescription(db, usrLogin, button.Name);
                recipeDescription.Show();
            }
        }

        private void ShowAllRecipes_Load(object sender, EventArgs e)
        {
            int recipeNum = db.getRecipeNum();
            string[][] previewText = new string[recipeNum][];
            for (int i = 0; i < recipeNum; i++)
            {
                previewText[i] = new string[2];
            }

            db.showRecipePreview(previewText);
            
            int top = 10;
            int left = 20;

            for (int i=0;i<recipeNum;i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Name = previewText[i][0];
                button.Click += ButtonOnClick;
                button.Height = 100;
                button.Width = 950;
                button.Text = previewText[i][1];
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Font = new Font("Constantia", 20f);


                this.Controls.Add(button);
                top += button.Height + 2;


            }



        }
    }
}
