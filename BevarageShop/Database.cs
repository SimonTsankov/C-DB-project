using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace BevarageShop
{

        public class Database
        {
            public SQLiteConnection myConnection;
            public Database()
            {

                myConnection = new SQLiteConnection("Data Source=database.sqlite3");
                if (!File.Exists("./database.sqlite3"))
                {

                    SQLiteConnection.CreateFile("database.sqlite3");
                using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                    #region SQL code for creation: 
                        @"CREATE TABLE ""Client"" (
	                        ""id_client""	INTEGER NOT NULL,
	                        ""EGN""	TEXT NOT NULL,
	                        ""name""	TEXT NOT NULL,
	                        ""adress""	TEXT NOT NULL,
	                        ""number""	TEXT NOT NULL,
	                        PRIMARY KEY(""id_client"")
                        );


                        CREATE TABLE ""Invoice"" (
	                        ""id_invoice""	INTEGER NOT NULL,
	                        ""id_client""	INTEGER NOT NULL,
	                        ""CreationDate""	TEXT NOT NULL,
	                        ""TotalCost""	INTEGER NOT NULL,
	                        FOREIGN KEY(""id_client"") REFERENCES Client(id_client),
	                        PRIMARY KEY(""id_invoice"")
                        );


                        CREATE TABLE ""Distributor"" (
	                        ""id_distributor""	INTEGER NOT NULL,
	                        ""name""	TEXT NOT NULL,
	                        ""phone_number""	TEXT NOT NULL,
	                        PRIMARY KEY(""id_distributor"")
                        );


                        CREATE TABLE ""Drink"" (
	                        ""id_drink""	INTEGER NOT NULL,
	                        ""name""	TEXT,
	                        ""bought""	INTEGER,
	                        ""price""	INTEGER,
	                        ""id_distributor""	INTEGER,
	                        ""date_added""	TEXT,
	                        FOREIGN KEY(""id_distributor"") REFERENCES Distributor(id_distributor),
	                        PRIMARY KEY(""id_drink"")
                        );


                        CREATE TABLE ""InvoiceItem"" (
	                        ""id_ivItem""	INTEGER NOT NULL,
	                        ""id_invoice""	INTEGER NOT NULL,
	                        ""quantity""	INTEGER NOT NULL,
	                        ""id_drink""	INTEGER NOT NULL,
	                        FOREIGN KEY(""id_invoice"") REFERENCES Invoice(id_invoice),
	                        FOREIGN KEY(""id_drink"") REFERENCES Drink(id_drink),
	                        PRIMARY KEY(""id_ivItem"")
                        );
                                            "
                    #endregion
                        , c))
                    {
                        

                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Database created!");
                }
            }
            public void OpenConnection()
            {
                if (myConnection.State != System.Data.ConnectionState.Open)
                {
                    myConnection.Open();
                }
            }
            public void CloseConnection()
            {
                if (myConnection.State != System.Data.ConnectionState.Closed)
                {
                    myConnection.Close();
                }
            }
        }
    }

