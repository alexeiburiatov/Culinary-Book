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
        public MainForm(Database.CookBookDB db, string login)
        {
            this.db = db;
            usrLogin = login;
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
