using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class RentManager
    {


        public static void InsertRent(string ID_t, string RoomNumber, DateTime DayStart, DateTime DayEnd, string TaxCode = null)
        {
 
            {   
                SqlCommand command = new SqlCommand("InsertRent", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID_t", ID_t);
                command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                command.Parameters.AddWithValue("@DayStart", DayStart);
                command.Parameters.AddWithValue("@DayEnd", DayEnd);
                command.Parameters.AddWithValue("@TaxCode", TaxCode);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Thông tin thuê phòng đã được thêm thành công.");
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
