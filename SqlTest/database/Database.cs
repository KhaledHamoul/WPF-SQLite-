using System;
using System.Data.SQLite;

namespace SqlTest
{
    public class Database
    {

        private SQLiteConnection connection;
        public SQLiteCommand commande;
        public SQLiteDataReader dataReader;

        public Database()
        {
            connection = new SQLiteConnection("Data Source=bezzierDB.db;New=true;Compress=true;");
            connection.Open();
            commande = connection.CreateCommand();
        }
       


    }
}
