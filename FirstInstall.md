# Introduction #

This is a guide on what you need to do upon first install to get everything working.


# Details #

First thing first,
> You will need to download all files in this directory https://code.google.com/p/mysql-read-write-saver/source/browse/trunk ( Svn checkout with http://mysql-read-write-saver.googlecode.com/svn/trunk/ ).

Now that everything is downloaded, you need to put all .cs scripts into your `Customs/` Directory somewhere(I did `Custom/MySQLSave/` to make svn easier to do.)

Now you will need to move `MySql.Data.dll` to your root runuo directory. Now find `Data/Assemblies.cfg` and add this line at the bottom: `MySql.Data.dll`



**Next** you need to open `MySQLConData.cs` and edit the database info for your database.
> ` public static string server = "localhost";`

> ` public static string database = "runuo";`

> ` public static string username = "root";`

> ` public static string password = "password";`


Find the next Wiki Page for more information on how to use after setup.