using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void UpdateProfile
            (
                int profileID,
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
            sqlite_cmd.CommandText = @"
                UPDATE main.Profile
                SET 
                    FIRST_NAME = '" + inputFirst + @"',
                    LAST_NAME = '" + inputLast + @"',
                    COMPANY = '" + inputCompany + @"',
                    JOB_TITLE = '" + inputJobTitle + @"',
                    STATE = '" + inputState + @"',
                    YEARLY_INCOME = " + inputSalary + @",
                    NOTES = '" + inputNotes + @"'
                WHERE
                    PROFILE_ID = " + profileID + ";";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public static void DeleteProfile(int profileID)
        {
            string sql_query = @"
                DELETE
                FROM main.Profile
                WHERE Profile.PROFILE_ID = " + profileID + ";";
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = sql_query;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public static System.Data.DataTable RetrieveProfiles()
        {
            System.Data.DataSet dataSet = new System.Data.DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            System.Data.DataRow[] dataRows = null;
            SQLiteDataAdapter dataAdapter = null;
            try
            {
                using (SQLiteConnection sqlite_conn = new SQLiteConnection())
                {
                    string sql_query = @"
                        SELECT
                            PROFILE_ID as 'Profile #',
                            FIRST_NAME as 'First Name',
                            LAST_NAME as 'Last Name',
                            COMPANY as Company,
                            JOB_TITLE as 'Job Title',
                            YEARLY_INCOME as 'Yearly Income',
                            STATE as State,
                            NOTES as Notes
                        FROM main.Profile;";
                    sqlite_conn.ConnectionString = "Data Source=BudgetTracker.db;Version=3;";
                    sqlite_conn.Open();
                    using (SQLiteCommand sqlCommand = sqlite_conn.CreateCommand())
                    {
                        dataAdapter = new SQLiteDataAdapter(sql_query, sqlite_conn);
                        dataSet.Reset();
                        dataAdapter.Fill(dataSet);
                        dataTable = dataSet.Tables[0];
                        dataRows = dataTable.Select();
                    }
                    sqlite_conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dataRows = null;
            }
            return dataTable;
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection
                (
                    "Data Source=BudgetTracker.db;Version=3;"
                );
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlite_conn;
        }
    }
}
