///The WinForms application will open a SQLite database on the disk using the OpenFileDialog control
///and display the contents of the SQLite database on a WinForms DataGridView Control for easy manipulation.
/// 
/// (c) 2025 www.xanthium.in
/// 
/// Platform : NetCore/Net7/Net 8
/// Author   : Rahul.Sreedharan
/// Tutorial : https://www.xanthium.in/building-csharp-sqlite-gui-crud-applications-using-winforms-api-tutorial/



using System.Data;
using System.Diagnostics;
using System.Data.SQLite;

namespace SQLite_Connection
{
    public partial class Form1 : Form
    {
        String SQliteDatabasePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Select_Database_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDatabaseFileDialog = new OpenFileDialog();
            OpenDatabaseFileDialog.InitialDirectory = Environment.CurrentDirectory;
            OpenDatabaseFileDialog.Title = "Open a SQLite Database";

            if (OpenDatabaseFileDialog.ShowDialog() == DialogResult.OK)
            {
                SQliteDatabasePath = OpenDatabaseFileDialog.FileName;
                TextBox_Database_Path.Text = SQliteDatabasePath;
                TextBox_Database_Name.Text = Path.GetFileName(SQliteDatabasePath);
            }



        }

        private void Button_Load_SQlite_Data_Click(object sender, EventArgs e)
        {
            String DatabaseConnectionString = "";
            String SQLQueryExecuted = "SELECT * FROM Customers";

            DatabaseConnectionString = $"Data Source={SQliteDatabasePath};FailIfMissing=True";

            TextBox_DB_Connection_String.Text = DatabaseConnectionString;
            TextBox_SQL_Query_Executed.Text = SQLQueryExecuted;


            using (SQLiteConnection MyConnection = new SQLiteConnection(DatabaseConnectionString)) // Create a SqliteConnection object called Connection
            {
                MyConnection.Open();              //open a connection to sqlite 3 database

                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SQLQueryExecuted, MyConnection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://www.youtube.com/watch?v=LUslHhvLGWA")
            {
                UseShellExecute = true  // Ensures the URL is opened in the default browser
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://www.xanthium.in/")
            {
                UseShellExecute = true  // Ensures the URL is opened in the default browser
            };
            System.Diagnostics.Process.Start(startInfo);

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://www.github.com/xanthium-enterprises/GUI-app-for-SQLite-database-CRUD-ops-using-CSharp-and-WinForms")
            {
                UseShellExecute = true  // Ensures the URL is opened in the default browser
            };
            System.Diagnostics.Process.Start(startInfo);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var startInfo = new System.Diagnostics.ProcessStartInfo("https://www.xanthium.in/building-csharp-sqlite-gui-crud-applications-using-winforms-api-tutorial/")
            {
                UseShellExecute = true  // Ensures the URL is opened in the default browser
            };
            System.Diagnostics.Process.Start(startInfo);

            
        }
    }
}
