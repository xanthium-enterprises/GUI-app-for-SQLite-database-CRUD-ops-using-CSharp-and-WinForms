// SQLiteDataAdapter class Tutorial
// Mke sure that sample database is in the same folder as the executable file 

using System.Data;
using System.Data.SQLite;


namespace SQLiteDataAdapterTutorial
{
    class SQLiteDataAdapterExamples
    {
        public static void Main()
        {
            String ConnectionString = @"Data Source=SampleSqliteDatabase.db"; 
            String SQLQuerySelectAll = "SELECT * FROM Customers";

            using (SQLiteConnection MyConnection = new SQLiteConnection(ConnectionString)) //Create a SqliteConnection object called Connection
            {
                MyConnection.Open(); //open a connection to the database 

                
                // Create a SQLiteDataAdapter to retrieve data
                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SQLQuerySelectAll, MyConnection))
                {
                    
                    DataTable dataTable = new DataTable(); // Create a DataTable to hold the data
                    dataAdapter.Fill(dataTable);           // Use the Fill method to retrieve data into the DataTable

                    //Display data
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Console.WriteLine($"ID: {row["id"]}, Name: {row["name"]},Age : {row["age"]} Email : {row["Email"]}");
                    }

                    //Console.WriteLine($"{dataTable.Rows[0]["name"]}");
                    //Console.WriteLine($"{dataTable.Rows[1]["name"]}");
                    //Console.WriteLine($"{dataTable.Rows[2]["name"]}");
                    
                }
            }




        }//End of Main()
    }//End of Class
}//End of namespace
