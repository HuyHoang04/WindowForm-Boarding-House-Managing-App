using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public class ConnectionManager
    {
        public string constring ;
        public SqlConnection con;
        public string InputID;
        public string InputPass;

        public static ConnectionManager Current;
        public ConnectionManager(string inputID, string inputPass)
        { // Nho doi ten laptop ???|||||||

            // constring = @"Data Source=LAPTOP-DGBCKMHH\SQLEXPRESS;Initial Catalog=BHM;User ID=" + inputID + ";Password=" + inputPass + ";";
            constring = @"Data Source=LAPTOP-DGBCKMHH\SQLEXPRESS;Initial Catalog=BHM;Integrated Security=True;";
            try
            {
                con = new SqlConnection(constring);
                con.Open(); // Test the connection by trying to open it
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Make sure to close the connection in the finally block
                if (con != null)
                {
                    con.Close();
                }
            }

        }
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }

        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

    }
}
