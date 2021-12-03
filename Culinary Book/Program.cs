using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culinary_Book.Database
{
    namespace Culinary_Book
    {
        static class Program
        {
            static Database Fsdf = new Database();
            

            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CulinaryBook());
                Fsdf.SqlConnetionFactory.
            }
        }
    }
}