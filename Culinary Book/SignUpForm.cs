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

        public Reg.RegExpr reg = new Reg.RegExpr();
        string msg;

        public SignUpForm()
        {
            InitializeComponent();
            submitDataButton.Enabled = false;
        }

        private void submitDataButton_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFNameInput_TextChanged(object sender, EventArgs e)
        {
            msg= reg.checkFName(textBoxEmailInput.Text);

            if(msg!="OK"||textBoxEmailInput.Text!="")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                submitDataButton.Enabled = false;
            }
            else
            {
                submitDataButton.Enabled = true;
            }
        }

        private void textBoxLNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordCheckInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
