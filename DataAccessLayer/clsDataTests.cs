using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    public class clsDataTests
    {
        public static bool AddNewTest(ref int NewTestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedBy)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                 VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                 SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes != null)
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedBy);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (int.TryParse(result.ToString(),out int InsertedID))
                {
                   NewTestID = InsertedID;
                    return true;
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

            return false;

        }


        public static bool IsPassedTestAlready(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT TOP 1 1 FROM Tests 
INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
AND TestTypeID = @TestTypeID 
AND TestResult = 1;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null) {
                    return true;
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

            return false;

        }

        public static bool NeedsRetakeTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT TOP 1 1 FROM Tests 
INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
AND TestTypeID = @TestTypeID 
AND TestResult = 0
ORDER BY TestID DESC;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                
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



    }
}
