using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackerMain
{
    class Database
    {
        public static void InsertProfile
            (
                string inputFirst, 
                string inputLast, 
                string inputState, 
                float inputSalary, 
                string inputCompany = null, 
                string inputJobTitle = null, 
                string inputNotes = null
            )
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = 
                "INSERT INTO main.Profile" +
                "   (" +
                "       DATE_CREATED," +
                "       FIRST_NAME," +
                "       LAST_NAME," +
                "       COMPANY," +
                "       JOB_TITLE," +
                "       STATE," +
                "       YEARLY_INCOME," +
                "       NOTES" +
                "   )" +
                "VALUES" +
                "   (" +
                        "'" + DateTime.Now.ToString("yyyyMMdd") + "' ," +
                        "'" + inputFirst + "' ," + 
                        "'" + inputLast + "' ," +
                        "'" + inputCompany + "' ," +
                        "'" + inputJobTitle + "' ," +
                        "'" + inputState + "' ," +
                        "" + inputSalary + "," + // Value is Real in DB
                        "'" + inputNotes + "'" +
                "   );";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public static System.Data.DataTable RetrieveProfiles()
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlite_Adapter = new SQLiteDataAdapter("SELECT * FROM main.Profile", sqlite_conn);
            System.Data.DataSet dataProfiles = new System.Data.DataSet("dataProfiles");
            sqlite_Adapter.Fill(dataProfiles);
            System.Data.DataTable tableProfile = dataProfiles.Tables.Add(new System.Data.DataTable("Profile"));
            sqlite_conn.Close();
            return tableProfile;
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection
                (
                    "Data Source = BudgetTracker.db;Version=3;"
                );
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
    }
}
