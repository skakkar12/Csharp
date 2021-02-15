using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace LINQSCENARIOS.LEARNINGCSHARP.ADODOTNET
{

    interface IDataOperations
    {
        void FillDataSet(string sql, string constr);
        void ReadAccessData(string sql, string constring);
        void LoadXMLDataset(string sql, string constring);

    }
    public class DataOperations:IDataOperations
    {

       
        public void FillDataSet(string sql, string constr)
        {
            try
            {
                SqlConnection con = CreateSqlConnection(constr);
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "dt");
                DataTable dt = ds.Tables["dt"];
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                        Console.WriteLine(row[col]);
                }  

            }
            catch (Exception)
            {
                
                throw;
            }

         }

        public void ReadAccessData(string sql, string constring)
        {
            OleDbConnection myOleDbConnection = new OleDbConnection(constring);
            
            OleDbCommand cmd = new OleDbCommand(sql);
            OleDbDataReader myOleDbDataReader = cmd.ExecuteReader();

            myOleDbDataReader.Read();
            Console.WriteLine("myOleDbDataReader[\"  CustomerID\"]  =  " + myOleDbDataReader["CustomerID"]);
            Console.WriteLine("myOleDbDataReader[\"  CompanyName\"]  =  " + myOleDbDataReader["CompanyName"]);
            Console.WriteLine("myOleDbDataReader[\"  ContactName\"]  =  " + myOleDbDataReader["ContactName"]);
            Console.WriteLine("myOleDbDataReader[\"  Address\"]  =  " + myOleDbDataReader["Address"]);

            myOleDbDataReader.Close();
            myOleDbConnection.Close();  
        }

        public SqlConnection CreateSqlConnection(string constring)
        {
            SqlConnection con = new SqlConnection(constring);
            return con;
        }

        public void LoadXMLDataset(string sql, string constring)
        {
            try
            {
                SqlConnection con = CreateSqlConnection(constring);
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "MyTable");
                ds.WriteXml(@"c:\Sample.xml");

            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}