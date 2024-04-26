using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class RoomManager
    {

        



        public static void InsertRoom(string RoomNumber, int Area, int Interior, bool State, decimal ElectricityPrice, decimal WaterPrice, string ID_l)
        {
 
            {
                SqlCommand command = new SqlCommand("InsertRoom", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                command.Parameters.AddWithValue("@Area", Area);
                command.Parameters.AddWithValue("@Interior", Interior);
                command.Parameters.AddWithValue("@State", State);
                command.Parameters.AddWithValue("@ElectricityPrice", ElectricityPrice);
                command.Parameters.AddWithValue("@WaterPrice", WaterPrice);
                command.Parameters.AddWithValue("@ID_l", ID_l);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Room inserted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static void UpdateRoom(string RoomNumber, int Area, int Interior, bool State, decimal ElectricityPrice, decimal WaterPrice, string ID_l)
        {
 
            {
                SqlCommand command = new SqlCommand("UpdateRoom", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                command.Parameters.AddWithValue("@Area", Area);
                command.Parameters.AddWithValue("@Interior", Interior);
                command.Parameters.AddWithValue("@State", State);
                command.Parameters.AddWithValue("@ElectricityPrice", ElectricityPrice);
                command.Parameters.AddWithValue("@WaterPrice", WaterPrice);
                command.Parameters.AddWithValue("@ID_l", ID_l);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Room updated successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static void DeleteRoom(string RoomNumber)
        {
 
            {
                SqlCommand command = new SqlCommand("DeleteRoom", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RoomNumber", RoomNumber);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Room deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
