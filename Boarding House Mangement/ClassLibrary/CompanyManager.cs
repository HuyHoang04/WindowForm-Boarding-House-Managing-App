using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class CompanyManager
    {


        public static void InsertCompany(string TaxCode, string Name, string Address, decimal Wallet, decimal BonusPrice, decimal PriceperMonth)
        {
                SqlCommand command = new SqlCommand("InsertCompany", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TaxCode", TaxCode);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Wallet", Wallet);
                command.Parameters.AddWithValue("@BonusPrice", BonusPrice);
                command.Parameters.AddWithValue("@PriceperMonth", PriceperMonth);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Company inserted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            
        }

        public static void UpdateCompany(string TaxCode, string Name, string Address, decimal Wallet, decimal BonusPrice, decimal PriceperMonth)
        {

                SqlCommand command = new SqlCommand("UpdateCompany", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TaxCode", TaxCode);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Wallet", Wallet);
                command.Parameters.AddWithValue("@BonusPrice", BonusPrice);
                command.Parameters.AddWithValue("@PriceperMonth", PriceperMonth);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Company updated successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            
        }

        public static void DeleteCompany(string TaxCode)
        {
 
            {
                SqlCommand command = new SqlCommand("DeleteCompany", ConnectionManager.Current.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TaxCode", TaxCode);

                try
                {
                    ConnectionManager.Current.openConnection();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Company deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
