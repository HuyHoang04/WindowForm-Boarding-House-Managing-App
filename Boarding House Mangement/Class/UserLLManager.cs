using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public static class UserLLManager
    {

        public static string GetUserId(string username)
        {
            string userId = null;

            // SQL query to retrieve user ID based on username
            string query = "SELECT ID_l FROM LOGIN_ACCOUNT_LL WHERE UserName = @Username";

            // Create connection and command objects

                using (SqlCommand command = new SqlCommand(query, ConnectionManager.Current.getConnection))
                {
                    // Add parameter for username
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        ConnectionManager.Current.openConnection();
                        // Execute the command
                        object result = command.ExecuteScalar();

                        // Check if a result was returned
                        if (result != null)
                        {
                            userId = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Handle exception
                    }
                }
            

            return userId;
        }
    }
}
