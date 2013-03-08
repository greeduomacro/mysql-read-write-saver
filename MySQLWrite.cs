using System;
using MySql.Data.MySqlClient;
using Server;
using Server.Commands;
using System.Net;

namespace Bittiez.MYSQL_Saver
{
    public class MySQLWrite
    {

        public static void Initialize()
        {
            CommandSystem.Register("[testmy", AccessLevel.Seer, new CommandEventHandler(MySQLWrite_OnCommand));
            Console.Write("Mysql Write loaded.");
            Console.WriteLine();
        }
        [Usage("testmy [description]")]
        [Description("Attempts to save to mysql.")]
        public static void MySQLWrite_OnCommand(CommandEventArgs e)
        {
            MySQLConData ConData = new MySQLConData();
            MySQLWrite my = new MySQLWrite();

            MySqlConnection con = ConData.Open_Connect(MySQLConData.db);
            if (my.write(con, e.Mobile.Serial, e.ArgString, 1))
                e.Mobile.SendMessage("Write successful");

            ConData.Close_Connection(con);
        }


        public bool write(MySqlConnection con, Serial serial, string String, int Identifier)
        {
            string type = "string", sql;
            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='"+serial.Value+"'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sql = "DELETE FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                    dataReader.Close();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                if (!dataReader.IsClosed) dataReader.Close();

                sql = "INSERT INTO `" + MySQLConData.database + "`.`" + type + "` (`id`, `serial`, `string`, `Iden`) VALUES (NULL, '" + serial.Value + "', '" + String + "', '" + Identifier + "');";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }

        public bool write(MySqlConnection con, Serial serial, DateTime dateTime, int Identifier)
        {
            string type = "dateTime", sql;
            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sql = "DELETE FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                    dataReader.Close();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                if (!dataReader.IsClosed) dataReader.Close();

                sql = "INSERT INTO `" + MySQLConData.database + "`.`" + type + "` (`id`, `serial`, `"+type+"`, `Iden`) VALUES (NULL, '" + serial.Value + "', '" + dateTime.Ticks + "', '" + Identifier + "');";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }

        public bool write(MySqlConnection con, Serial serial, IPAddress value, int Identifier)
        {
            long data = Utility.GetLongAddressValue(value);

            string type = "ipaddress", sql;
            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sql = "DELETE FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                    dataReader.Close();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                if (!dataReader.IsClosed) dataReader.Close();

                sql = "INSERT INTO `" + MySQLConData.database + "`.`" + type + "` (`id`, `serial`, `" + type + "`, `Iden`) VALUES (NULL, '" + serial.Value + "', '" + data + "', '" + Identifier + "');";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }

        public bool write(MySqlConnection con, Serial serial, int value, int Identifier)
        {
            string type = "int", sql;
            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sql = "DELETE FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                    dataReader.Close();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                if (!dataReader.IsClosed) dataReader.Close();

                sql = "INSERT INTO `" + MySQLConData.database + "`.`" + type + "` (`id`, `serial`, `" + type + "`, `Iden`) VALUES (NULL, '" + serial.Value + "', '" + value + "', '" + Identifier + "');";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }

        public bool write(MySqlConnection con, Serial serial, TimeSpan value, int Identifier)
        {
            string type = "timespan", sql;
            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sql = "DELETE FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                    dataReader.Close();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                if (!dataReader.IsClosed) dataReader.Close();

                sql = "INSERT INTO `" + MySQLConData.database + "`.`" + type + "` (`id`, `serial`, `" + type + "`, `Iden`) VALUES (NULL, '" + serial.Value + "', '" + value.Ticks + "', '" + Identifier + "');";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }

        public bool write(MySqlConnection con, Serial serial, decimal value, int Identifier)
        {
            string type = "decimal", sql;
            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sql = "DELETE FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                    dataReader.Close();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                if (!dataReader.IsClosed) dataReader.Close();

                sql = "INSERT INTO `" + MySQLConData.database + "`.`" + type + "` (`id`, `serial`, `" + type + "`, `Iden`) VALUES (NULL, '" + serial.Value + "', '" + value + "', '" + Identifier + "');";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }

        public bool write(MySqlConnection con, Serial serial, long value, int Identifier)
        {
            string type = "long", sql;
            try
            {
                sql = "SELECT * FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    sql = "DELETE FROM `" + MySQLConData.database + "`.`" + type + "` WHERE Iden='" + Identifier + "' AND serial='" + serial.Value + "'";
                    dataReader.Close();
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                if (!dataReader.IsClosed) dataReader.Close();

                sql = "INSERT INTO `" + MySQLConData.database + "`.`" + type + "` (`id`, `serial`, `" + type + "`, `Iden`) VALUES (NULL, '" + serial.Value + "', '" + value + "', '" + Identifier + "');";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }
    }
}
