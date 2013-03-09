using System;
using Server;
using Server.Items;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using Bittiez.MYSQL_Saver;
using MySql.Data.MySqlClient;
using System.Net;

namespace Server.Items
{
    public class Test_Item : Item
    {
        private string Test;
        private DateTime dateTime;
        private IPAddress ipaddress;
        private int Int;
        private TimeSpan timespan;
        private decimal deCimal;
        private long loNg;
        private uint uiNt;

        [Constructable]
        public Test_Item()
            : base(0x108F)
        {
            LootType = LootType.Blessed;
            Movable = true;
            Name = "A Test Item";
            Hue = 5;
            Test = "default";
            dateTime = new DateTime(1);
            ipaddress = new IPAddress(1);
            Int = 5;
            timespan = new TimeSpan(1);
            deCimal = (decimal)1.5;
            loNg = (long)123456789;
            uiNt = (uint)123456;
        }

        public Test_Item(Serial serial)
            : base(serial)
        {
        }

        public override void GetProperties(ObjectPropertyList list)
        {

            base.GetProperties(list);
            list.Add(Test + " | " + dateTime.ToLongTimeString() + " | " + ipaddress.ToString() + " | " + Int + " | " + timespan.TotalSeconds + " | " + deCimal.ToString()
                + " | " + loNg.ToString() + " | " + uiNt.ToString());

        }



        public override void OnDoubleClick(Mobile m)
        {
            
            Random ran = new Random();
            int random = ran.Next(999999999);
            Test = random.ToString();
            dateTime = new DateTime(random);
            ipaddress = m.NetState.Address;
            Int = random;
            timespan = new TimeSpan(random);
            deCimal = ((decimal)random / (decimal)77.3);
            loNg = (long)random;
            uiNt = (uint)random;
            this.InvalidateProperties();
        }


        public override void Serialize(GenericWriter writer)
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

            MySQLConData ConData = new MySQLConData(); //Methods used for connect/disconnect/storing database info
            MySQLWrite MySqlWrite = new MySQLWrite(); //Methods for writing data

            MySqlConnection con = ConData.Open_Connect(MySQLConData.db); //Open a new MySQL Connection

            MySqlWrite.write(con, this.Serial, Test, 1); //Attempt to write string Test identified by 1
            MySqlWrite.write(con, this.Serial, dateTime, 1); //Attempt to write a DateTime
            MySqlWrite.write(con, this.Serial, ipaddress, 1); //Attempt to write an IPAddress
            MySqlWrite.write(con, this.Serial, Int, 1); //Attempt to write an int
            MySqlWrite.write(con, this.Serial, timespan, 1); //Attempt to write a TimeSpan
            MySqlWrite.write(con, this.Serial, deCimal, 1); //Attempt to write a decimal
            MySqlWrite.write(con, this.Serial, loNg, 1); //Attempt to write a decimal
            MySqlWrite.write(con, this.Serial, uiNt, 1); //Attempt to write a uint
            //Do other writes here before closing the connect. Also, all write functions return a boolean for success or failure

            ConData.Close_Connection(con); //Close connection after writing everything


		}

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();


            MySQLConData ConData = new MySQLConData(); //Methods used for connect/disconnect/storing database info
            MySQLRead MySqlRead = new MySQLRead(); //Methods for reading data

            MySqlConnection con = ConData.Open_Connect(MySQLConData.db); //Open a new MySQL Connection

            Test = MySqlRead.readString(con, this.Serial, "No data found", 1); //Attempt to read a string, if no string is found in the DB, return No data found
            dateTime = MySqlRead.readDateTime(con, this.Serial, new DateTime(1), 1); //Attempt to read DateTime
            ipaddress = MySqlRead.readIPAddress(con, this.Serial, new IPAddress(1), 1); //Attempt to read IPAddress
            Int = MySqlRead.readInt(con, this.Serial, 1, 1); //Attempt to read int
            timespan = MySqlRead.readTimeSpan(con, this.Serial, new TimeSpan(1), 1); //Attempt to read timespan
            deCimal = MySqlRead.readDecimal(con, this.Serial, (decimal)1.5, 1); //Read decimal
            loNg = MySqlRead.readLong(con, this.Serial, (long)1.5, 1); //Read long
            uiNt = MySqlRead.readUint(con, this.Serial, (uint)1577, 1); //Read uint

            ConData.Close_Connection(con); //Close connection after reading everything

        }

    }


}