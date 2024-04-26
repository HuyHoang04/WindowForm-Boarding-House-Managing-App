﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class ConnectionManager
    {
        public string constring ;
        public SqlConnection con;
        public string InputID;
        public string InputPass;

        public static ConnectionManager Current;
        public ConnectionManager(string inputID, string inputPass)
        {
            constring = @"Data Source=LAPTOP-DGBCKMHH\SQLEXPRESS;Initial Catalog=BHM;User ID=" + inputID + ";Password=" + inputPass + ";";
            try
            {
                con = new SqlConnection(constring);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }

        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

    }
}
