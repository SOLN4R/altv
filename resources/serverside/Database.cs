using AltV.Net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace serverside
{
    class Database : Core
    {
        public static bool isDatabaseConnected = false;
        public static MySqlConnection? Connection;
        public string dbHost {  get; set; }
        public string dbUsername { get; set; }
        public string dbPassword { get; set; }
        public string dbName { get; set; }

        public Database()
        {
            this.dbHost = "localhost";
            this.dbUsername = "root";
            this.dbPassword = "root";
            this.dbName = "altvcanitrp";
        }

        private static string GetConnectionString()
        {
            Database sql = new Database();
            string SQLConnection = $"SERVER={sql.dbHost}; DATABASE={sql.dbName}; UID={sql.dbUsername}; Password={sql.dbPassword}";
            return SQLConnection;
        }

        public static void InitConnection()
        {
            string SQLConnection = GetConnectionString();
            Connection = new MySqlConnection(SQLConnection);
            try
            {
                Connection.Open();
                isDatabaseConnected = true;
                Alt.Log("[INFO] Соединение с базой данных установлено.");

            } catch (Exception ex)  { 
                isDatabaseConnected = false;
                Alt.Log("[ERROR] Неудачное подключение к базе данных.");
                Alt.Log(ex.ToString());
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }

        public static void CloseConnection()
        {
            if (isDatabaseConnected && Connection != null)
            {
                try
                {
                    Connection.Close();
                    Connection.Dispose();
                    isDatabaseConnected = false;
                    Alt.Log("[INFO] Соединение с базой данных закрыто.");
                }
                catch (Exception ex)
                {
                    Alt.Log("[ERROR] Ошибка при закрытии соединения с базой данных.");
                    Alt.Log(ex.ToString());
                }
            }
        }
    }
}