using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Culinary_Book.Database
{
    public class Database
    {
        public static string connectionString = @"Data Source=20.101.112.215;Initial Catalog=culinarybook;User ID=sa";
        public static Database singleton;
        public static SqlConnection sqlConnection;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public SqlConnection SqlConnetionFactory
        {

            get { return sqlConnection; }
        }

            
        public Database() { }

        public static Database Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = new Database();

                sqlConnection = new SqlConnection(connectionString);
                return singleton;
            }
        }

    }


}
}
