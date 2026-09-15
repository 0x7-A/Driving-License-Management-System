using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
     public class clsDataApplication
    {
    

        public static bool AddNewApplication(ref int ApplicationID ,int ApplicantPersonID,DateTime ApplicationDate,int ApplicationTypeID,int ApplicationStatus,DateTime LastStatusDate, decimal PaidFees,int CreatedByUserID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID,   ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID,   @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int AppID))
                {
                    ApplicationID = AppID;
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

        public static bool FindAppIDbyLDLApp(ref int AppID,int ApplicantPersonID,int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT TOP 1 Applications.ApplicationID
                        FROM Applications 
                     INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                    WHERE Applications.ApplicantPersonID = @ApplicantPersonID 
                     AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                      AND Applications.ApplicationStatus = 1;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open ();

                object result = cmd.ExecuteScalar();

                if(result !=  null && int.TryParse(result.ToString(), out AppID))
                {
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

        public static bool DeleteByApplicationID(int ApplicationID)
        {


            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"delete from Applications where ApplicationID = @ApplicationID;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            

            try
            {
                connection.Open();

                int RowsEffected = cmd.ExecuteNonQuery();

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

        public static bool FindApplicationInfoByID(int ApplicationID,
    ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID,
    ref byte ApplicationStatus, ref DateTime LastStatusDate,
    ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

   
            string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                   
                    isFound = true;

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            
            {
                isFound = false;
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }




    }
}
