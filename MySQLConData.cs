using MySql.Data.MySqlClient;

namespace Bittiez.MYSQL_Saver
{
    public class MySQLConData
    {
        //Edit settings here
        public static string server = "localhost";
        public static string database = "runuo";
        public static string username = "root";
        public static string password = "password";
        //Do not edit anything below here unless you know what you're doing.


        public static string db = "server=" + server + ";database=" + database + ";uid=" + username + ";password=" + password + ";"; //Don't touch this line.

        public MySqlConnection Open_Connect(string DB_Connect_String)
        {
            MySqlConnection con = new MySqlConnection(DB_Connect_String);
            con.Open();
            return con;
        }
        public MySqlConnection Open_Connect(string server, string database, string username, string password)
        {
            string db = "server=" + server + ";database=" + database + ";uid=" + username + ";password=" + password + ";";
            MySqlConnection con = new MySqlConnection(db);
            con.Open();
            return con;
        }
        public void Close_Connection(MySqlConnection db)
        {
            db.Close();
        }
    }
}
