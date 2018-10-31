using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace BasicConnectMariaDB
{
    class ConnectDB
    {
    //    string mySQLConnectionString = "server=localhost;id=root;database=tbl_id_telegram";

    //    string GetValueFromDB(string sqlConnectionString)
    //    {
    //        string strData = "";

    //        try
    //        {
    //            using (var mysqlconnection = new MySqlConnection(mySQLConnectionString))
    //            {
    //                mysqlconnection.Open();
    //                using (MySqlCommand cmd = mysqlconnection.CreateCommand())
    //                {
    //                    cmd.CommandType = System.Data.CommandType.Text;
    //                    cmd.CommandTimeout = 300;
    //                    cmd.CommandText = mySQLConnectionString;

    //                    object objectValue = cmd.ExecuteScalar();
    //                    if(objectValue == null)
    //                    {
    //                        cmd.Dispose();
    //                        return string.Empty;
    //                    } else
    //                    {
    //                        strData = (string)cmd.ExecuteScalar();
    //                        cmd.Dispose();
    //                    }

    //                    mysqlconnection.Close();
    //                }
    //            }
    //        }
    //        catch(Exception excp)
    //        {
    //            Console.WriteLine("Failed to Load sqlConnectionString");
    //        }

    //        return strData;
    //    }
    }
}
