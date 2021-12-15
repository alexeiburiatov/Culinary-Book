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
    public partial class NewRecipe : Form
    {
        private Database.CookBookDB db;
        private static string usrLogin;
        private List<string> pathes;
        public NewRecipe(Database.CookBookDB db, string login)
        {
            pathes = new List<string>();
            this.db = db;
            usrLogin = login;
            InitializeComponent();

        }

        private void recipeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                pathes.Clear();
                foreach (String file in openFileDialog.FileNames)
                {
                    pathes.Add(file);
                }
                MessageBox.Show("Фотографії успішно додані!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void createRecipeButton_Click(object sender, EventArgs e)
        {
            byte[] imageByte=null;

            if (recipeTextBox.Text=="" || ingredientsTextBox.Text== "" || headerTextBox.Text== "")
            {
                MessageBox.Show("Усі поля повинні бути заповнені!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string recipeId= db.addNote(usrLogin, headerTextBox.Text, ingredientsTextBox.Text, recipeTextBox.Text);
                if (recipeId.Length<10)
                {
                    for(int i=0; i<pathes.Count();i++)
                    {
                        imageByte = System.IO.File.ReadAllBytes(pathes[i]);
                        string msg = db.addImage(recipeId, imageByte);
                        if(msg!="200")
                        {
                            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show("Рецепт успішно створено", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(recipeId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ingredientsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void headerTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
