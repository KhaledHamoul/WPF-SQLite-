using System;

using System.Windows;
using System.Windows.Data;


namespace SqlTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Database db = new Database();
            var id = "'khaled'"; 
            db.commande.CommandText = "SELECT * FROM users WHERE users.username = " + id  ;
            db.dataReader = db.commande.ExecuteReader();

           

            while (db.dataReader.Read())
            {
                Console.WriteLine("==================================================================");

                Console.WriteLine("id : " + db.dataReader.GetInt32(0) + "nom : " + db.dataReader.GetString(1) + "MDP : " + db.dataReader.GetString(2));
                Console.WriteLine("==================================================================");


            }

            db.commande.Dispose();
            var username = "salah ";
            var psw = "salahPassword";
            string cmd = "INSERT INTO users (username , password ) VALUES ('" + username + "','"  + psw + "');";

            db.commande.CommandText = cmd;


            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(cmd);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            db.commande.ExecuteNonQuery();





        }
    }
}
