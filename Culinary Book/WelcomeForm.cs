using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Culinary_Book
{
    public partial class CulinaryBook : Form
    {
        private Database.CookBookDB db;

        public CulinaryBook(Database.CookBookDB db)
        {
            this.db = db;
            InitializeComponent();
            db.getSqlConnetion.Open();
            using (SqlCommand command = new SqlCommand("SELECT * FROM private.[userInfo]", this.db.getSqlConnetion))
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            
            db.getEntryStatus("adsdfsdfmin","admin");

        }





        private void textBoxLoginInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomeLabelForm1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string msg;
            msg=db.getEntryStatus(textBoxLoginInput.Text, textBoxPasswordInput.Text);
            if(msg!="200")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
