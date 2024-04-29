using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class WalletLandlordManager
    {

        public void InsertWalletLandlord(string ID_w, decimal Balance)
        {

            SqlCommand command = new SqlCommand("InsertWalletLandlord", ConnectionManager.Current.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID_w", ID_w);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                ConnectionManager.Current.openConnection();
                command.ExecuteNonQuery();
                Console.WriteLine("Đã thêm Wallet Landlord thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

        }

        public void UpdateWalletLandlord(string ID_w, decimal Balance)
        {

            SqlCommand command = new SqlCommand("UpdateWalletLandlord", ConnectionManager.Current.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID_w", ID_w);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                ConnectionManager.Current.openConnection();
                command.ExecuteNonQuery();
                Console.WriteLine("Đã cập nhật Wallet Landlord thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
       
    }

        public void DeleteWalletLandlord(string ID_w)
        {

                SqlCommand command = new SqlCommand("DeleteWalletLandlord", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID_w", ID_w);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Đã xóa Wallet Landlord thành công.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
        }
        
    }
}
