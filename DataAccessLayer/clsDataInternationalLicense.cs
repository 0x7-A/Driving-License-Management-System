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
    public class clsDataInternationalLicense
    {

        public static DataTable GetInternationalHistoryByPersonID(int PersonID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT 
    InternationalLicenses.InternationalLicenseID, 
    InternationalLicenses.ApplicationID, 
    InternationalLicenses.IssuedUsingLocalLicenseID, 
    InternationalLicenses.IssueDate, 
    InternationalLicenses.ExpirationDate, 
    InternationalLicenses.IsActive
FROM InternationalLicenses
INNER JOIN Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID
WHERE Applications.ApplicantPersonID = @PersonID;";

            SqlCommand command  = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
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

        public static DataTable GetMangeInternationalAppDataTable()
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT 
    InternationalLicenseID AS [Int. License ID], 
    ApplicationID AS [Application ID], 
    DriverID AS [Driver ID], 
    IssuedUsingLocalLicenseID AS [L. License ID], 
    IssueDate AS [Issue Date], 
    ExpirationDate AS [Expiration Date], 
    IsActive AS [Is Active]
FROM InternationalLicenses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
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

        public static bool AddNewInternationalLicense(ref int InternationalLicenseID, int ApplicationID,int DriverID,int IssuedUsingLocalLicenseID,
            DateTime IssueDate,DateTime ExpirationDate,bool IsActive,int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[InternationalLicenses]
           ([ApplicationID]
           ,[DriverID]
           ,[IssuedUsingLocalLicenseID]
           ,[IssueDate]
           ,[ExpirationDate]
           ,[IsActive]
           ,[CreatedByUserID])
     VALUES
           (@ApplicationID
           ,@DriverID
           ,@IssuedUsingLocalLicenseID
           ,@IssueDate
           ,@ExpirationDate
           ,@IsActive
           ,@CreatedByUserID);
SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(),out int ID))
                {
                    InternationalLicenseID = ID;
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


        public static bool CheckIfTheLicenseIDUsed(int LicenseID, ref int InternationalID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT top 1 InternationalLicenseID 
                 FROM InternationalLicenses 
                 WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID 
                   AND IsActive = 1 
                   AND ExpirationDate >= GETDATE();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    InternationalID = ID;
                    return true;
                }
                

            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally { connection.Close(); }

            return false;
        }

        public static bool GetInternationalLicenseByID(int InternationalLicenseID,
    ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
    ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive,
    ref int CreatedByUserID, ref int ApplicantPersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

         
            string query = @"SELECT InternationalLicenses.*, Applications.ApplicantPersonID
                     FROM InternationalLicenses 
                     INNER JOIN Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID
                     WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                   
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                }
                reader.Close();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }


    }
}
