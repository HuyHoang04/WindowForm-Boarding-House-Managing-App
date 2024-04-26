using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class LandlordManager
    {

        public static void InsertLandlord(string ID_l, string Name, string PhoneNumber, DateTime Birthday, string ID_w)
        {
 
            {
                SqlCommand command = new SqlCommand("InsertLandlord", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID_l", ID_l);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Birthday", Birthday);
                command.Parameters.AddWithValue("@ID_w", ID_w);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Landlord inserted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static void UpdateLandlord(string ID_l, string Name, string PhoneNumber, DateTime Birthday)
        {
 
            {
                SqlCommand command = new SqlCommand("UpdateLandlord", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID_l", ID_l);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Birthday", Birthday);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Landlord updated successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static void DeleteLandlord(string ID_l)
        {
 
            {
                SqlCommand command = new SqlCommand("DeleteLandlord", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID_l", ID_l);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Landlord deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static DataTable FindLandlordByID(string ID_l)
        {
 
            {
                SqlCommand command = new SqlCommand("SELECT * FROM FindLandlordByID(@ID_l)", ConnectionManager.Current.getConnection);
                command.Parameters.AddWithValue("@ID_l", ID_l);

                DataTable table = new DataTable();

                try
                {
                    ConnectionManager.Current.openConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                return table;
            }
        }

    }
}
