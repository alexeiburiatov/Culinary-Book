using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        public string checkExistingLogin(string pLoginName)
        {
            string sql = string.Format("DECLARE	@responseMessage nvarchar(250);" +
                "EXEC private.uspCheckLogin " +
                    "@pLoginName," +
                    "@responseMessage = @responseMessage OUTPUT;" +
                "SELECT  @responseMessage as N'@responseMessage'");
            using (SqlCommand cmd = new SqlCommand(sql, this.getSqlConnetion))
            {

                String msgEntryStatus;
                SqlDataReader dr = null;
                cmd.Parameters.AddWithValue("pLoginName", pLoginName);
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
                return msgEntryStatus;

            }
        }

        public string checkExistingEmail(string pEmail)
        {
            string sql = string.Format("DECLARE	@responseMessage nvarchar(250);" +
                "EXEC private.uspCheckEmail " +
                    "@pEmail," +
                    "@responseMessage = @responseMessage OUTPUT;" +
                "SELECT  @responseMessage as N'@responseMessage'");
            using (SqlCommand cmd = new SqlCommand(sql, this.getSqlConnetion))
            {

                String msgEntryStatus;
                SqlDataReader dr = null;
                cmd.Parameters.AddWithValue("pEmail", pEmail);
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
                return msgEntryStatus;

            }
        }

        public string addUser(string pLogin,string pPassword, string pFirstName, string pLastName, string pEmail)
        {
            string sql = string.Format("EXEC private.uspAddUser " +
                "@pLogin," +
                "@pPassword," +
                "@pFirstName," +
                "@pLastName," +
                "@pEmail");
            using (SqlCommand cmd = new SqlCommand(sql, this.getSqlConnetion))
            {

                String msgEntryStatus;
                cmd.Parameters.AddWithValue("pLogin", pLogin);
                cmd.Parameters.AddWithValue("pPassword", pPassword);
                cmd.Parameters.AddWithValue("pFirstName", pFirstName);
                cmd.Parameters.AddWithValue("pLastName", pLastName);
                cmd.Parameters.AddWithValue("pEmail", pEmail);
                try
                {
                    cmd.ExecuteNonQuery();
                    msgEntryStatus = "200";
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
                return msgEntryStatus;

            }
        }

        public string[] showUserInfo(string pLogin)
        {

            string sql = string.Format("EXEC private.extractPersonalInfo " +
                "@pLogin= \""+ pLogin+"\"");

            string[] pInfo= new string[3];
            using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connectionString))
            {

                DataTable result = new DataTable();
                myDataAdapter.Fill(result);

                foreach (DataRow o in result.Select())
                {
                    pInfo[0] = o["firstName"].ToString();
                    pInfo[1] = o["lastName"].ToString();
                    pInfo[2] = o["email"].ToString();
                }

            }



            return pInfo;
        }


        public string editNote(string pLogin, string pNoteText)
        {
            string sql = string.Format("EXEC private.uspEditNotes " +
                "@pLoginName, " +
                "@pNoteText");
            using (SqlCommand cmd = new SqlCommand(sql, this.getSqlConnetion))
            {

                String msgEntryStatus;
                cmd.Parameters.AddWithValue("pLoginName", pLogin);
                cmd.Parameters.AddWithValue("pNoteText", pNoteText);
                try
                {
                    cmd.ExecuteNonQuery();
                    msgEntryStatus = "200";
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
                return msgEntryStatus;

            }
        }


        public string showNotes(string pLogin)
        {

            string sql = string.Format("EXEC private.getNotes " +
                "@pLoginName= \"" + pLogin + "\"");

            string noteText = null;
            using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connectionString))
            {

                DataTable result = new DataTable();
                myDataAdapter.Fill(result);

                foreach (DataRow o in result.Select())
                {
                   noteText = o["noteText"].ToString();
                }

            }




            return noteText;
        }

        public string addNote(string pLogin, string pHeaderName, string pIngredients, string pRecipeText)
        {
            string sql = string.Format("EXEC private.uspAddRecipe " +
                "@pLoginName= '" + pLogin+
                "' , @pHeaderName= '" + pHeaderName+
                "', @pIngredients=  '" + pIngredients+
                "', @pRecipeText= '"+ pRecipeText+"'");
            string lastId = null;

            using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connectionString))
            {

                DataTable result = new DataTable();
                myDataAdapter.Fill(result);

                foreach (DataRow o in result.Select())
                {
                    lastId = o["idnt"].ToString();
                }

            }
            return lastId;
        }

        public string addImage(string pRecipeId , byte[] pFilePath)
        {
            string sql = string.Format("EXEC private.uspAddImage " +
                "@pRecipeId," +
                "@pFilePath "); 
            using (SqlCommand cmd = new SqlCommand(sql, this.getSqlConnetion))
            {

                String msgEntryStatus;
                cmd.Parameters.AddWithValue("pRecipeId", pRecipeId);
                cmd.Parameters.Add("pFilePath", SqlDbType.VarBinary);
                cmd.Parameters["pFilePath"].Value = pFilePath;

                try
                {
                    cmd.ExecuteNonQuery();
                    msgEntryStatus = "200";
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
                return msgEntryStatus;

            }
        }

        public int getRecipeNum()
        {

            string sql = string.Format("EXEC private.getRecipeNum ");

            string num = null;
            using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connectionString))
            {

                DataTable result = new DataTable();
                myDataAdapter.Fill(result);

                foreach (DataRow o in result.Select())
                {
                    num = o["cnt"].ToString();
                }

            }
            return Convert.ToInt32(num);
        }



        public void showRecipePreview(string[][] data)
        {

            string sql = string.Format("EXEC private.getRecipePreview ");

            using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connectionString))
            {

                DataTable result = new DataTable();
                myDataAdapter.Fill(result);

                int i = 0;
                foreach (DataRow o in result.Select())
                {
                    data[i][0] = o["recipeId"].ToString();
                    data[i][1] = o["headerName"].ToString();
                    i++;
                }
            }
        }




        public string[] getFullRecipe( string pRecipeId)
        {
            string[] data = new string[3];
            string sql = string.Format("EXEC private.getFullRecipe " +
                "@precipeId= " + pRecipeId);
            using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, connectionString))
            {

                DataTable result = new DataTable();
                myDataAdapter.Fill(result);

                foreach (DataRow o in result.Select())
                {
                    data[0] = o["headerName"].ToString();
                    data[1] = o["ingredients"].ToString();
                    data[2] = o["recipeText"].ToString();
                }
            }
            return data;
        }




    }


}

