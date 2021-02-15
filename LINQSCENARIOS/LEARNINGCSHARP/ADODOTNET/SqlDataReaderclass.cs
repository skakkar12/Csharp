using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace LINQSCENARIOS.LEARNINGCSHARP.ADODOTNET
{
    public class SqlDataReaderclass
    {
        public static void Main(String[] args)
        {
            SqlDataReaderclass reader = new SqlDataReaderclass();
            string constr = "";
            reader.SimpleRead(constr);
        }

        private void SimpleRead(string constr)
        {
            SqlDataReader dr = null;

            //SqlConnection con = new SqlConnection("");
            SqlConnection con = CreateSQLConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from customers", con);

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    string contact = (string)dr["ContactName"];
                    string company = (string)dr["CompanyName"];
                    string city = (string)dr["City"];

                    // print out the results
                    Console.Write("{0,-25}", contact);
                    Console.Write("{0,-20}", city);
                    Console.Write("{0,-25}", company);
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {

                if (dr != null)
                {
                    dr.Close();
                }

                // close the connection
                if (con != null)
                {
                    con.Close();
                }

            }
        }

        private SqlConnection CreateSQLConnection(string constr)
        {
            SqlConnection con = new SqlConnection(constr);
            return con;
        }
    }
}