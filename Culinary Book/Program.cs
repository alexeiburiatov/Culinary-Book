using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



    namespace Culinary_Book
    {
    
    static class Program
        {
        private static Database.CookBookDB db = new Database.CookBookDB();
        

        [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CulinaryBook(db));
            }
        }
    }