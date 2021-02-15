using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ResearchCSharp.NEWADO.NET
{
    class executenonquery
    {
        public static void Main(String[] args)
        {
            string constring = null;
            string sql = null;

            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql="select";
                con = new SqlConnection(constring);
                cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
