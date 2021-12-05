using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Culinary_Book.Database
{
    public class CookBookDB
    {
        static string connectionString = @"Data Source=20.101.112.215;Initial Catalog=culinarybook;User ID=sa;Password=<4auq-@@XB-(c)h>";
        static CookBookDB singleton;
        static SqlConnection sqlConnection;
        public CookBookDB()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public SqlConnection getSqlConnetion
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new CookBookDB();
                }
                return sqlConnection;
            }
        }


        public string getEntryStatus(string pLoginName, string pPassword) 
        {
            string sql = string.Format("DECLARE  @responseMessage nvarchar(250);" +
                " EXEC private.uspLogin " +
                    "@pLoginName," +
                    " @pPassword," +
                    " @responseMessage = @responseMessage OUTPUT;" +
                " SELECT  @responseMessage as N'@responseMessage'");
            using (SqlCommand cmd = new SqlCommand(sql, this.getSqlConnetion))
            {

                String msgEntryStatus;
                SqlDataReader dr=null;
                cmd.Parameters.AddWithValue("pLoginName", pLoginName);
                cmd.Parameters.AddWithValue("pPassword", pPassword);
                try
                {
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    msgEntryStatus = dr.GetString(0);
                    dr.Close();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
                //finally
                //{
                    
                //}

                return msgEntryStatus;

            }
        }

    }


}

