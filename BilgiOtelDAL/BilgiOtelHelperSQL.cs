using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BilgiOtelDAL
{
    public class BilgiOtelHelperSQL
    {
        //SqlConnection
        private static SqlConnection Myconnection()
        {
            return new SqlConnection(DataConnections.Get_MsSqlConnectionString);
        }


        //SqlCommand

        public static SqlCommand mySqlCommand(string sqlScript, string myScriptType, SqlParameter[] myParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlScript;
            cmd.Connection = Myconnection();

            if (myScriptType == "sp")
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }

            if (myParameters != null)
            {
                cmd.Parameters.AddRange(myParameters);

            }

            return cmd;
            //SqlCommand cmd = new SqlCommand("",baglanti);
        }

        // Execute Metodlar

        public static int myExecuteNonQuery(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);

            cmd.Connection.Open();
            int donenSatir = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return donenSatir;

        }

        //SqlCommand, executeScalar

        public static object myExecuteScalar(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            object donenDeger = cmd.ExecuteScalar();
            cmd.Connection.Close();

            return donenDeger;

        }

        //SqlCommand, ExecuteReader
        public static SqlDataReader myExecuteReader(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            SqlDataReader okuma = cmd.ExecuteReader();
            // DataTable dt = new DataTable();
            // while (okuma.Read())
            //{
            //     dt.Load(okuma);
            //}
            //cmd.Connection.Close();
            // return dt;

            return okuma;
        }

        public static DataTable myexecuteReaderTable(string spName,SqlParameter[] cmdParams,string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName,myCommandType,cmdParams);
            cmd.Connection.Open();
            SqlDataReader gelen=cmd.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(gelen);
            cmd.Connection.Close();
            return tablo;
        }
    }
}
