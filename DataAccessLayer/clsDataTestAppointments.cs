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
    public class clsDataTestAppointments
    {

        public static DataTable GetAllTestAppoitementWLDLAppIDAndTestType(int LDLAppID, int TestType)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT TestAppointmentID as [TestAppointment ID], 
               AppointmentDate as [Appointment Date], 
               PaidFees as [Paid Fees], 
               IsLocked as [Is Locked]
                FROM TestAppointments 
                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                 AND TestTypeID = @TestTypeID;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID ",LDLAppID);
            cmd.Parameters.AddWithValue("@TestTypeID",TestType);

            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

               
                    dt.Load(reader);
                 
                
                return dt;

            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return dt;

            }
            finally
            {
                connection.Close();
            }
        }

        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID,
                                         DateTime AppointmentDate, decimal PaidFees,
                                         int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

         
            string query = @"INSERT INTO [dbo].[TestAppointments]
                       ([TestTypeID]
                       ,[LocalDrivingLicenseApplicationID]
                       ,[AppointmentDate]
                       ,[PaidFees]
                       ,[CreatedByUserID]
                       ,[IsLocked], RetakeTestApplicationID)
                 VALUES
                       (@TestTypeID
                       ,@LocalDrivingLicenseApplicationID
                       ,@AppointmentDate
                       ,@PaidFees
                       ,@CreatedByUserID
                       ,@IsLocked, @RetakeTestApplicationID);
                 SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

           
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if(RetakeTestApplicationID == -1)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar(); 

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
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

            return TestAppointmentID;
        }


        public static bool UpdateAppointmentDate(int TestAppointmentID,DateTime Date)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"UPDATE TestAppointments Set
              AppointmentDate = @AppointmentDate
            WHERE  TestAppointmentID =@TestAppointmentID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@AppointmentDate",Date);


            try
            {
                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result > 0;
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


        public static bool UpdateIsLockedToFalse(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"UPDATE TestAppointments Set
     IsLocked = 1
 WHERE  TestAppointmentID =@TestAppointmentID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
           

            try
            {
                connection.Open();

                int result = cmd.ExecuteNonQuery();

                return result > 0;

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


        public static bool HasAnActiveAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT TOP 1 1 FROM TestAppointments 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                     AND TestTypeID = @TestTypeID 
                     AND IsLocked = 0;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                return (result != null); 

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

        public static int GetTotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int TotalTrials = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

          
            string query = @"SELECT count(*) FROM TestAppointments 
                     INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                     WHERE TestResult = 0 
                     AND TestTypeID = @TestTypeID 
                     AND LocalDrivingLicenseApplicationID = @LDLAID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLAID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar(); 

                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    TotalTrials = count;
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return TotalTrials;
        }

        public static bool GetTestAppointmentInfoByID(int TestAppointmentID,
    ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
    ref DateTime AppointmentDate, ref decimal PaidFees,
    ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                   
                    RetakeTestApplicationID = (reader["RetakeTestApplicationID"] == DBNull.Value) ? -1 : (int)reader["RetakeTestApplicationID"];
                }
                reader.Close();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }
            finally { connection.Close(); }
            return isFound;
        }



    }
}
