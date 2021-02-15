using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace ResearchCSharp.NEWADO.NET
{
    class Sqlcommandexecutenonquery
    {
        public static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            string constring = null;
            string sql;
            constring = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            con = new SqlConnection(constring);
            sql="select";

            try
            {
                con.Open();

                cmd = new SqlCommand(sql, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
