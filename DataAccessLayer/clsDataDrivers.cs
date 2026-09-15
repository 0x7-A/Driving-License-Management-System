using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    public class clsDataDrivers
    {
        public static DataTable GetAllDrivers()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            DataTable dt = new DataTable();
            string query = "select * from Drivers;";

            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally
            {
                connection.Close();
            }


            return dt;
        }


        // check , add new 

        public static int AddNewDriver(int PersonID, int CreatedBy)
        {
            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"INSERT INTO Drivers
           (PersonID
           ,CreatedByUserID
           ,CreatedDate)
     VALUES
           (@PersonID,@CreatedByUserID,GETDATE()); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedBy);

            try
            {
                Connection.Open();
                
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    return ID;
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally
            {
                Connection.Close();
            }


            return -1;
        }


        public static bool CheckIfHasAlreadyDriverID(int PersonID)
        { 
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"select top 1 1 from Drivers
where PersonID=@PersonID; ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                int RowEffected = cmd.ExecuteNonQuery();
                return RowEffected > 0;

            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally
            {
                connection.Close();
            }

            return false;
        }


        public static int GetDriverIDByPersonID(int PersonID)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT DriverID FROM Drivers WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    DriverID = ID;
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally
            {
                connection.Close();
            }

            return DriverID;
        }



    }
}
