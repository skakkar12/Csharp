using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ResearchCSharp.ADONET
{
    class sqlmultiresults
    {
        public static void Main(string[] args)
        {
            string connetionString = null;
            SqlConnection sqlCnn;
            SqlCommand sqlCmd;
            string sql = null;

            connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            sql = "Select top 2 * from product; select top 2 * from ordermaster; select top 2 * from orderdetails";

            sqlCnn = new SqlConnection(connetionString);
            try
            {
                sqlCnn.Open();
                sqlCmd = new SqlCommand(sql, sqlCnn);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    Console.WriteLine("From first SQL - " + sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1));
                }

                sqlReader.NextResult();

                while (sqlReader.Read())
                {
                    Console.WriteLine("From second SQL - " + sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1));
                }

                sqlReader.NextResult();

                while (sqlReader.Read())
                {
                    Console.WriteLine("From third SQL - " + sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1));
                }

                sqlReader.Close();
                sqlCmd.Dispose();
                sqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }
        }
    }
}