using System;
using System.Data.SqlClient;

namespace WebApplication.DataAccess
{
    public class DataAccess
    {
        private string conecctionString = System.Configuration.ConfigurationManager.ConnectionStrings["DemoDBConnectionString"].ConnectionString;

        public bool ValidateUser(string username, string passwords) 
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }

        }


    }
}
