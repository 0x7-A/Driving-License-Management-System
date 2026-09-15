using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project_DataAccessLayer
{
    public class clsDataLDLApplication
    {

        public static bool CheckFromPreivousApp(ref int DLDAppID, int PersonID ,int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT top 1 LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID FROM  
         LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
         where Applications.ApplicantPersonID =@PersonID and  LicenseClasses.LicenseClassID =@LicenseClassID and Applications.ApplicationStatus = 1";

            SqlCommand cmd  = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    DLDAppID = ID;
                    return true;
                }

            }

            catch (Exception e)
            {

                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);



                return false;
            }

            finally
            {
                connection.Close();
            }




            return false;

        }

        public static bool AddNewLDLApp(ref int DLDAppID, int ApplicationID , int LicenseClassID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
        

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    DLDAppID = AppID;
                    return true;
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return false;




        }

        public static bool UpdateApplicationToCancell(int ApplicationID,int ApplicationTypeID,int ApplicationStatus)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "UPDATE Applications SET ApplicationTypeID = @ApplicationTypeID, ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                connection.Open();
                int RowsEffected = command.ExecuteNonQuery();

                
                
                    return RowsEffected > 0;
                

            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return false;
            }

            finally
            {
                connection.Close();
            }
       

        }


        public static bool DeleteLDLApp(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                int rowsEffected = cmd.ExecuteNonQuery();


                return rowsEffected > 0;


            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return false;
            }

            finally
            {
                connection.Close();
            }


        }

        public static bool GetLocalDrivingLicenseApplicationInfoByID(
    int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int ApplicantPersonID,
    ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus,
    ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID,
    ref string LicenseClassName, ref byte PassedTestCount)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);


            string query = @";SELECT 
    LDLA.LocalDrivingLicenseApplicationID, 
    App.*, 
    LC.ClassName,

    (SELECT COUNT(TestID) 
     FROM Tests 
     INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
     WHERE TestAppointments.LocalDrivingLicenseApplicationID = LDLA.LocalDrivingLicenseApplicationID 
     AND Tests.TestResult = 1) AS PassedTestCount
FROM LocalDrivingLicenseApplications LDLA
INNER JOIN Applications App ON LDLA.ApplicationID = App.ApplicationID
INNER JOIN LicenseClasses LC ON LDLA.LicenseClassID = LC.LicenseClassID
WHERE LDLA.LocalDrivingLicenseApplicationID = @LDLAID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAID",LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    LicenseClassName = (string)reader["ClassName"];

                    PassedTestCount = Convert.ToByte(reader["PassedTestCount"]);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                isFound = false;
            }

            finally { connection.Close(); }

            return isFound;
        }



    }
}
