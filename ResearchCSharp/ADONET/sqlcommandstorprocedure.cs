using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ResearchCSharp.ADONET
{
    class sqlcommandstorprocedure
    {

        public static void Main(String[] args)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            DataSet ds = new DataSet();

            int i = 0;

            connetionString = "Data Source=servername;Initial Catalog=PUBS;User ID=sa;Password=yourpassword";
            connection = new SqlConnection(connetionString);

            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SPPUBLISHER";
            adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                Console.WriteLine(ds.Tables[0].Rows[i][0].ToString());
            }
            connection.Close();
        }
    }
}