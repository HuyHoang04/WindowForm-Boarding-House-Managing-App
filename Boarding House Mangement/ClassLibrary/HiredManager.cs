using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class HiredManager
    {

         

        public static void InsertHired(string ID_l, string TaxCode, DateTime DayStart, DateTime DayEnd)
        {
 
            {
                SqlCommand command = new SqlCommand("InsertHired", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID_l", ID_l);
                command.Parameters.AddWithValue("@TaxCode", TaxCode);
                command.Parameters.AddWithValue("@DayStart", DayStart);
                command.Parameters.AddWithValue("@DayEnd", DayEnd);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Thông tin thuê công ty môi giới đã được thêm thành công.");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000) // Custom error number from RAISERROR
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    else
                    {
                        Console.WriteLine("Error: " + ex.Number + " - " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
