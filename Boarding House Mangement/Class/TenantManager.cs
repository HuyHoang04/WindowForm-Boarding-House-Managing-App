using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class TenantManager
    {

        public void InsertTenant(string ID_t, string Name, string PhoneNumber, string Job, DateTime Birthday, decimal Balance)
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

        public void UpdateTenant(string ID_t, string Name, string PhoneNumber, string Job, DateTime Birthday, decimal Balance)
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

        public void DeleteTenant(string ID_t)
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

        public DataTable FindTenantByID(string ID_t)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM FindTenantByID(@ID_t)", ConnectionManager.Current.getConnection);
            command.Parameters.AddWithValue("@ID_t", ID_t);

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
