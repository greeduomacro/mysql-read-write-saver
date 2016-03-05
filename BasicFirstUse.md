# Introduction #

This page will demonstrate how to use this in its most simple form.


# Details #

I have included a `Test_Item.cs` that includes examples of saving and loading different types of data that will be a very good resource if you need help.

Now, lets begin:

**First:** You need to add the following lines at the top of your item script:

`using Bittiez.MYSQL_Saver;`

`using MySql.Data.MySqlClient;`

**Second:** Find your Serialize and Deserialize methods of your item.
We are going to add three lines to being with:

`MySQLConData ConData = new MySQLConData(); //Methods used for connect/disconnect/storing database info`

`MySQLWrite MySqlWrite = new MySQLWrite(); //Methods for writing data`

`MySqlConnection con = ConData.Open_Connect(MySQLConData.db); //Open a new MySQL Connection`


Now we can **begin writing**:

`MySqlWrite.write(con, this.Serial, "test", 1); //Attempt to write string test identified by 1`


This functions writes to the con connection, with this objects serial, the string "text" and is identified by 1.
To learn more about identifiers and how these functions work please see the advanced read/write wiki page.

It seems we need to write an int also:

`MySqlWrite.write(con, this.Serial, Int, 1); //Attempt to write an int`



Now we are done writing and **need to close the connection**:

`ConData.Close_Connection(con); //Close connection after writing everything`

And that sums up the Serialize method.




**Deserialize:**

Okay first we need those same three lines we had before(Almost the same anyways):

`MySQLConData ConData = new MySQLConData(); //Methods used for connect/disconnect/storing database info`

`MySQLRead MySqlRead = new MySQLRead(); //Methods for reading data`

`MySqlConnection con = ConData.Open_Connect(MySQLConData.db); //Open a new MySQL Connection`

Now we can read data:

`string Test = MySqlRead.readString(con, this.Serial, "No data found", 1); //Attempt to read a string with identifier 1, if no string is found in the DB, return No data found`
int Int = MySqlRead.readInt(con, this.Serial, 5, 1); //Attempt to read int with identifier 1, return 5 if no data found.


Now we have to **close the connection again**:

`ConData.Close_Connection(con); //Close connection after reading everything`