using Microsoft.Data.SqlClient;
using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecr19_DataAccessLayer
{
    public static class clsDataMigrationData
    {
     
        public static DataTable GetAllUsersForMigration()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
            {
                string query = "SELECT UserID, PasswordPlaintext FROM Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception e)
                    {
                        EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                    }
                }
            }
            return dt;
        }

      
        public static bool UpdateUserPasswordHash(int UserID, string PasswordHash)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
            {
                string query = @"UPDATE Users 
                                 SET PasswordHash = @PasswordHash 
                                 WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 64).Value = PasswordHash;

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }
    }
}
