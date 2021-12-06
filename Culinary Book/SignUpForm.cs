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
    public partial class SignUpForm : Form
    {
        private Database.CookBookDB db;
        public Reg.RegExpr reg = new Reg.RegExpr();
        string msg;

        public SignUpForm(Database.CookBookDB db)
        {
            this.db = db;
            InitializeComponent();
            submitDataButton.Enabled = false;
        }
        private bool checkAllFields()
        {
            bool status = false;
            if(textBoxFNameInput.ForeColor == Color.Black &&
                 textBoxFNameInput.Text != ""&&
                textBoxLNameInput.ForeColor == Color.Black&&
                textBoxLNameInput.Text != ""&&
                textBoxPasswordInput.ForeColor == Color.Black&&
                textBoxPasswordInput.Text != ""&&
                textBoxPasswordCheckInput.ForeColor == Color.Black&&
                textBoxPasswordInput.Text != ""&&
                textBoxEmailInput.ForeColor == Color.Black&&
                textBoxEmailInput.Text != ""&&
                textBoxLoginInput.ForeColor == Color.Black&&
                textBoxLoginInput.Text != ""
                )
            {
                status = true;
            }
            return status;
        }

        private void submitDataButton_Click(object sender, EventArgs e)
        {
            msg= db.addUser(textBoxLoginInput.Text, textBoxPasswordInput.Text, textBoxFNameInput.Text, textBoxLNameInput.Text, textBoxEmailInput.Text);
            if (msg != "200")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Користувач успішно зареєстрований!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBoxFNameInput_TextChanged(object sender, EventArgs e)
        {
            textBoxFNameInput.ForeColor = Color.Black;

        }


        private void textBoxFNameInput_Leave(object sender, System.EventArgs e)
        {

            msg = reg.checkFName(textBoxFNameInput.Text);

            if (msg != "OK" || textBoxFNameInput.Text == "")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                submitDataButton.Enabled = false;
                textBoxFNameInput.ForeColor = Color.Red;
            }
            else
            {
                if (checkAllFields())
                {
                    submitDataButton.Enabled = true;
                }

                textBoxFNameInput.ForeColor = Color.Black;
            }
        }


        private void textBoxLNameInput_TextChanged(object sender, EventArgs e)
        {
            textBoxLNameInput.ForeColor = Color.Black;
        }

        private void textBoxLNameInput_Leave(object sender, System.EventArgs e)
        {

            msg = reg.checkLName(textBoxLNameInput.Text);

            if (msg != "OK" || textBoxLNameInput.Text == "")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                submitDataButton.Enabled = false;
                textBoxLNameInput.ForeColor = Color.Red;
            }
            else
            {
                if (checkAllFields())
                {
                    submitDataButton.Enabled = true;
                }
                textBoxLNameInput.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordInput_TextChanged(object sender, EventArgs e)
        {
            textBoxPasswordInput.ForeColor = Color.Black;
        }

        private void textBoxPasswordInput_Leave(object sender, System.EventArgs e)
        {

            msg = reg.checkPassword(textBoxPasswordInput.Text);

            if (msg != "OK" || textBoxPasswordInput.Text == "")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                submitDataButton.Enabled = false;
                textBoxPasswordInput.ForeColor = Color.Red;
            }
            else
            {
                if (checkAllFields())
                {
                    submitDataButton.Enabled = true;
                }
                textBoxPasswordInput.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordCheckInput_TextChanged(object sender, EventArgs e)
        {
            textBoxPasswordCheckInput.ForeColor = Color.Black;

        }

        private void textBoxPasswordCheckInput_Leave(object sender, System.EventArgs e)
        {

            msg = reg.doubleCheckPassword(textBoxPasswordCheckInput.Text, textBoxPasswordInput.Text);

            if (msg != "OK" || textBoxPasswordInput.Text == "")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                submitDataButton.Enabled = false;
                textBoxPasswordCheckInput.ForeColor = Color.Red;
            }
            else
            {
                if (checkAllFields())
                {
                    submitDataButton.Enabled = true;
                }
                textBoxPasswordCheckInput.ForeColor = Color.Black;
            }
        }
        private void textBoxEmailInput_TextChanged(object sender, EventArgs e)
        {
            textBoxEmailInput.ForeColor = Color.Black;

        }

        private void textBoxEmailInput_Leave(object sender, System.EventArgs e)
        {

            msg = reg.checkEmail(textBoxEmailInput.Text);

            string msgCheckEmail;
            msgCheckEmail = db.checkExistingEmail(textBoxEmailInput.Text);
            if (msgCheckEmail != "200")
            {
                textBoxEmailInput.ForeColor = Color.Red;
                MessageBox.Show(msgCheckEmail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (msg != "OK" || textBoxEmailInput.Text == "")
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    submitDataButton.Enabled = false;
                    textBoxEmailInput.ForeColor = Color.Red;
                }
                else
                {
                    if (checkAllFields())
                    {
                        submitDataButton.Enabled = true;
                    }
                    textBoxEmailInput.ForeColor = Color.Black;
                }
            }
            
        }


        private void textBoxLoginInput_TextChanged(object sender, EventArgs e)
        {
            textBoxLoginInput.ForeColor = Color.Black;
        }

        private void textBoxLoginInput_Leave(object sender, System.EventArgs e)
        {

            msg = reg.checkLogin(textBoxLoginInput.Text);

            string msgCheckLogin;
            msgCheckLogin = db.checkExistingLogin(textBoxLoginInput.Text);
            if (msgCheckLogin != "200")
            {
                textBoxLoginInput.ForeColor = Color.Red;
                MessageBox.Show(msgCheckLogin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (msg != "OK" || textBoxLoginInput.Text == "")
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    submitDataButton.Enabled = false;
                    textBoxLoginInput.ForeColor = Color.Red;
                }
                else
                {
                    if (checkAllFields())
                    {
                        submitDataButton.Enabled = true;
                    }
                    textBoxLoginInput.ForeColor = Color.Black;
                }
            }


        }
    }
}
