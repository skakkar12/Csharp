using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace LINQSCENARIOS.LEARNINGCSHARP.ADODOTNET
{

    interface ISQLStoredprocedure
    {
        void Runprocedureparams();
        void Runprocedure();
    }
    public class SQLStoredprocedure: ISQLStoredprocedure
    {
        public static void main(String[] args)
        {
            SQLStoredprocedure spd = new SQLStoredprocedure();

            spd.Runprocedure();
            spd.Runprocedureparams();

        }

        private void Runprocedureparams()
        {
            throw new NotImplementedException();
        }

        private void Runprocedure()
        {
            SqlConnection con = null;
            SqlDataReader dr = null;

            try
            {
                con = new SqlConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("stored procedure name", con);
                cmd.CommandType = CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(
                    "Product: {0,-25} Price: ${1,6:####.00}",
                    dr["TenMostExpensiveProducts"],
                    dr["UnitPrice"]);

                }


            }
            catch (Exception)
            {

                throw;
            }

            finally
            {

            }
        }

        void ISQLStoredprocedure.Runprocedureparams()
        {
            throw new NotImplementedException();
        }

        void ISQLStoredprocedure.Runprocedure()
        {
            throw new NotImplementedException();
        }
    }
}