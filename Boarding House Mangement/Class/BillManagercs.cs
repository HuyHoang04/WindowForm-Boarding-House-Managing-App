using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public static class BillManagercs
    {

         

        public static void InsertBill(string Code, float ElectricNumber, float WaterNumber, DateTime Day, string ID_l, string RoomNumber, string ID_t)
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

        public static void UpdateBill(string Code, float ElectricNumber, float WaterNumber, DateTime Day)
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
        public static DataTable FindBillByCode(string code)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = ConnectionManager.Current.getConnection)
            {
                SqlCommand command = new SqlCommand("FindBillByCode", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Code", code);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                    else
                    {
                        Console.WriteLine($"Không tìm thấy hóa đơn với mã '{code}'");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }
    
    }
}
