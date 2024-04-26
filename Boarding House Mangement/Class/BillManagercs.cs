using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class BillManagercs
    {

         

        public void InsertBill(string Code, float ElectricNumber, float WaterNumber, DateTime Day, string ID_l, string RoomNumber, string ID_t)
        {

                SqlCommand command = new SqlCommand("InsertBill", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Code", Code);
                command.Parameters.AddWithValue("@ElectricNumber", ElectricNumber);
                command.Parameters.AddWithValue("@WaterNumber", WaterNumber);
                command.Parameters.AddWithValue("@Day", Day);
                command.Parameters.AddWithValue("@ID_l", ID_l);
                command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                command.Parameters.AddWithValue("@ID_t", ID_t);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Đã thêm Bill thành công.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            
        }

        public void UpdateBill(string Code, float ElectricNumber, float WaterNumber, DateTime Day)
        {
                SqlCommand command = new SqlCommand("UpdateBill", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Code", Code);
                command.Parameters.AddWithValue("@ElectricNumber", ElectricNumber);
                command.Parameters.AddWithValue("@WaterNumber", WaterNumber);
                command.Parameters.AddWithValue("@Day", Day);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Đã cập nhật Bill thành công.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            

        }
    }
}
