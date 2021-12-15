using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace Culinary_Book
{
    public partial class MainForm : Form
    {
        private Database.CookBookDB db;
        private static string usrLogin;
        private string[] usrInfo = new string[3];
        public MainForm(Database.CookBookDB db, string login)
        {
            this.db = db;
            usrLogin = login;
            usrInfo = this.db.showUserInfo(login);
            InitializeComponent();
            this.textBoxLoginOutput.Text = login;
            this.textBoxFNameOutput.Text = usrInfo[0];
            this.textBoxLNameOutput.Text = usrInfo[1];
            this.textBoxEmailOutput.Text = usrInfo[2];

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void нотаткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteSheet notesheet = new NoteSheet(db, usrLogin);
            notesheet.ShowDialog();
        }

        private void textBoxLNameOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmailOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFNameOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRecipe_Click(object sender, EventArgs e)
        {
            NewRecipe newRecipe = new NewRecipe(db, usrLogin);
            newRecipe.ShowDialog();
        }

        private void ShowAllRecipe_Click(object sender, EventArgs e)
        {
            AllRecipes allRecipes = new AllRecipes(db, usrLogin);
            allRecipes.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
