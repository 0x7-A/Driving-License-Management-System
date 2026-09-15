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
    public class clsDataLocalDrivingLicenseApp
    {

        public static DataTable GetAllLocalAppTyeps()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT LDLA.LocalDrivingLicenseApplicationID AS [L.D.L.AppID], 
               LC.ClassName AS [Driving Class], P.NationalNo AS [National No.], 
            (P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName) AS [Full Name],
             A.ApplicationDate AS [Application Date],
    

    (SELECT COUNT(TestID) 
     FROM Tests 
     INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
     WHERE TestAppointments.LocalDrivingLicenseApplicationID = LDLA.LocalDrivingLicenseApplicationID 
     AND Tests.TestResult = 1) AS [Passed Tests],

    CASE 
        WHEN A.ApplicationStatus = 1 THEN 'New'
        WHEN A.ApplicationStatus = 2 THEN 'Canclled'
        WHEN A.ApplicationStatus = 3 THEN 'Completed'
    END AS [Status]

FROM LocalDrivingLicenseApplications LDLA
INNER JOIN Applications A ON LDLA.ApplicationID = A.ApplicationID
INNER JOIN People P ON A.ApplicantPersonID = P.PersonID
INNER JOIN LicenseClasses LC ON LDLA.LicenseClassID = LC.LicenseClassID; ";



            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dt.Load(reader);
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

            return dt;
        }

        public static DataTable GetLocalLicenseHistoryByID(int PersonID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT 
    Licenses.LicenseID, 
    Licenses.ApplicationID, 
    LicenseClasses.ClassName, 
    Licenses.IssueDate, 
    Licenses.ExpirationDate, 
    Licenses.IsActive
FROM Licenses 
INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
WHERE Drivers.PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dt.Load(reader);
                }

            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally { connection.Close(); }

            return dt;
        }





    }
}
