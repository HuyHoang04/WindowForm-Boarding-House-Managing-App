using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class TenantManager
    {

        public static void InsertTenant(string ID_t, string Name, string PhoneNumber, string Job, DateTime Birthday, decimal Balance)
        {

            SqlCommand command = new SqlCommand("InsertTenant", ConnectionManager.Current.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID_t", ID_t);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Job", Job);
            command.Parameters.AddWithValue("@Birthday", Birthday);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                ConnectionManager.Current.openConnection();
                command.ExecuteNonQuery();
                Console.WriteLine("Tenant inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public static void UpdateTenant(string ID_t, string Name, string PhoneNumber, string Job, DateTime Birthday, decimal Balance)
        {

            SqlCommand command = new SqlCommand("UpdateTenant", ConnectionManager.Current.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID_t", ID_t);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Job", Job);
            command.Parameters.AddWithValue("@Birthday", Birthday);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                ConnectionManager.Current.openConnection();
                command.ExecuteNonQuery();
                Console.WriteLine("Tenant updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public static void DeleteTenant(string ID_t)
        {

            SqlCommand command = new SqlCommand("DeleteTenant", ConnectionManager.Current.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID_t", ID_t);

            try
            {
                ConnectionManager.Current.openConnection();
                command.ExecuteNonQuery();
                Console.WriteLine("Tenant deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public static DataTable FindTenantByID(string ID_t)
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = ConnectionManager.Current.getConnection)
                {
                    using (SqlCommand command = new SqlCommand("FindTenantByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID_t", ID_t);

                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return table;
        }
    }
}
