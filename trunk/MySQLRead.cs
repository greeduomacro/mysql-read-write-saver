using System;
using MySql.Data.MySqlClient;
using Server;
using Server.Commands;
using System.Net;


namespace Bittiez.MYSQL_Saver
{
    public class MySQLRead
    {

        public static void Initialize()
        {
            CommandSystem.Register("[readmy", AccessLevel.Seer, new CommandEventHandler(MySQLRead_OnCommand));
            Console.Write("Mysql Read Loaded.");
            Console.WriteLine();
        }
        [Usage("readmy [description]")]
        [Description("Attempts to save to mysql.")]
        public static void MySQLRead_OnCommand(CommandEventArgs e)
        {
            MySQLConData ConData = new MySQLConData();
            MySQLRead my = new MySQLRead();

            MySqlConnection con = ConData.Open_Connect(MySQLConData.db);

            e.Mobile.SendMessage(my.readString(con, e.Mobile.Serial, e.ArgString, 1));

            ConData.Close_Connection(con);

            e.Mobile.SendMessage("Done.");
        }


        public string readString(MySqlConnection con, Serial serial, string return_if_no_data, int Identifier)
        {
            string type = "string", sql, stringg = return_if_no_data;

            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    stringg = (string)dataReader["string"];
                    int id = (int)dataReader["id"];
                    dataReader.Close();
                }
                if (stringg.Length < 1) return return_if_no_data;
                return stringg;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return return_if_no_data;
            }
        }

        public DateTime readDateTime(MySqlConnection con, Serial serial, DateTime return_if_no_data, int Identifier)
        {
            string type = "dateTime", sql;
            DateTime stringg = return_if_no_data;

            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    stringg = new DateTime((long)dataReader["dateTime"]);
                    dataReader.Close();
                }
                return stringg;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return return_if_no_data;
            }
        }

        public IPAddress readIPAddress(MySqlConnection con, Serial serial, IPAddress return_if_no_data, int Identifier)
        {
            string type = "ipaddress", sql;
            IPAddress stringg = return_if_no_data;

            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    stringg = new IPAddress((long)dataReader[type]);
                    dataReader.Close();
                }
                return stringg;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return return_if_no_data;
            }
        }

        public int readInt(MySqlConnection con, Serial serial, int return_if_no_data, int Identifier)
        {
            string type = "int", sql;
            int stringg = return_if_no_data;

            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    stringg = ((int)dataReader[type]);
                    dataReader.Close();
                }
                return stringg;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return return_if_no_data;
            }
        }

        public TimeSpan readTimeSpan(MySqlConnection con, Serial serial, TimeSpan return_if_no_data, int Identifier)
        {
            string type = "timespan", sql;
            TimeSpan stringg = return_if_no_data;

            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    stringg = new TimeSpan((long)dataReader[type]);
                    dataReader.Close();
                }
                return stringg;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return return_if_no_data;
            }
        }

        public decimal readDecimal(MySqlConnection con, Serial serial, decimal return_if_no_data, int Identifier)
        {
            string type = "decimal", sql;
            decimal stringg = return_if_no_data;

            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    stringg = ((decimal)dataReader[type]);
                    dataReader.Close();
                }
                return stringg;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return return_if_no_data;
            }
        }

        public long readLong(MySqlConnection con, Serial serial, long return_if_no_data, int Identifier)
        {
            string type = "long", sql;
            long stringg = return_if_no_data;

            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    stringg = ((long)dataReader[type]);
                    dataReader.Close();
                }
                return stringg;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return return_if_no_data;
            }
        }
    }
}
