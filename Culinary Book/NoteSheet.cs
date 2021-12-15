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
    public partial class NoteSheet : Form
    {
        private Database.CookBookDB db;
        private static string usrLogin;
        public NoteSheet(Database.CookBookDB db, string login)
        {
            this.db = db;
            usrLogin = login;
            InitializeComponent();
            this.recipeTextBox.Text = db.showNotes(usrLogin);
        }

        private void recipeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string msg;
            msg = db.editNote(usrLogin, recipeTextBox.Text);
            if (msg != "200")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Нотатки оновлені", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoteSheet_Load(object sender, EventArgs e)
        {

        }
    }
}
