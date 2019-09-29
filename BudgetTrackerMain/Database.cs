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
        public static void InsertProfile(string inputFirst, string inputLast, string inputCompany = null, string inputJobTitle = null, string inputState, float inputSalary, string inputNotes = null)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = 
                "INSERT INTO dbo.Profile" +
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

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection
                (
                    "Data Source = BudgetTracker.db;Version=3;New=True;Compress=True;"
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
