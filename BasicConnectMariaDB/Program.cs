using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BasicConnectMariaDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            string query = "SELECT *"
                + "FROM tbl_id_telegram";

            //test.OpenConnection();
            test.Select(query);
            
            Console.ReadKey();
        }

    


    //CLASS DBCONNECT
    //class DBConnect
    //{
        private MySqlConnection connection;
        private string server;
        private string database;
        private string userid;
        private string password;

        public Program()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "belajar_mariadb";
            userid = "root";
            password = "Password1234";
            string connectionString;

            connectionString = "SERVER=" + server + ";"
                + "DATABASE=" + database + ";"
                + "UID=" + userid + ";"
                + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Berhasil Tersambung");
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private void Select(string query)
        {
            string hasil;

            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader["id_telegram"].ToString());
                    Console.WriteLine(dataReader["nama_telegram"].ToString());
                }

                Console.ReadLine();

                dataReader.Close();

                this.CloseConnection();
            }
            else
            {
                hasil = "Pencarian Tidak Ditemukan";   
            }
            
            
        }
    }
}

