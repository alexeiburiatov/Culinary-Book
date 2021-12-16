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
    public partial class Comments : Form
    {
        private Database.CookBookDB db;
        private static string usrLogin;
        private string recipeId;
        private List<string> history= null;
        public Comments(Database.CookBookDB db, string login, string recipeId)
        {
            this.db = db;
            usrLogin = login;
            this.recipeId = recipeId;
            InitializeComponent();
            refreshComments();
        }

        private void commentsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void sendCommButton_Click(object sender, EventArgs e)
        {
            if (messageBox.Text == "")
            {
                MessageBox.Show("Пусте повідомлення!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string msg= db.addComment(this.recipeId, usrLogin, this.messageBox.Text);
                if (msg != "200")
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refreshComments();
            this.messageBox.Text = "";

        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void refreshComments()
        {
            commentsBox.Text = "";
            history=db.getCommentsHistory(this.recipeId);
            for(int i=0; i<history.Count(); i++)
            {
                commentsBox.AppendText(history[i]+ "--------------"+ "\r\n" + "\r\n");
            }
        }
    }
}
