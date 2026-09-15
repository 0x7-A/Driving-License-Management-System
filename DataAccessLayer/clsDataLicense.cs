using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    public class clsDataLicense
    {


        public static bool GetLicenseByLDLAppID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseID, ref int DriverID, ref int LicenseClass,
                      ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
                      ref decimal PaidFees, ref bool IsActive, ref string IssueReason, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT Licenses.LicenseID, 
                            Licenses.ApplicationID, 
                            Licenses.DriverID, 
                            Licenses.LicenseClass, 
                            Licenses.IssueDate, 
                            Licenses.ExpirationDate, 
                            Licenses.Notes, 
                            Licenses.PaidFees, 
                            Licenses.IsActive, 
                            Licenses.IssueReason,
                            Licenses.CreatedByUserID 
                     FROM Applications 
                     INNER JOIN Licenses ON Applications.ApplicationID = Licenses.ApplicationID 
                     INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                     WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];


                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else
                    {
                        Notes = "";
                    }


                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];

                    byte ReasonID = (byte)reader["IssueReason"];


                    switch (ReasonID)
                    {
                        case 1:
                            IssueReason = "First Time";
                            break;
                        case 2:
                            IssueReason = "Renew";
                            break;
                        case 3:
                            IssueReason = "Replacement for Damaged";
                            break;
                        case 4:
                            IssueReason = "Replacement for Lost";
                            break;
                        default:
                            IssueReason = "Unknown";
                            break;
                    }


                    CreatedByUserID = (int)reader["CreatedByUserID"];
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



        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID,
    ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
    ref string Notes, ref decimal PaidFees, ref bool IsActive,
    ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);


            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];


                    Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];

                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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


        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isDetained = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);


            string query = @"SELECT top 1 1 
                     FROM DetainedLicenses 
                     WHERE LicenseID = @LicenseID AND IsReleased = 0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isDetained = true;
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            finally { connection.Close(); }

            return isDetained;



        }


       

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
                                   DateTime IssueDate, DateTime ExpirationDate, string Notes,
                                   decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

           
            string query = @"INSERT INTO [dbo].[Licenses]
                       ([ApplicationID], [DriverID], [LicenseClass], [IssueDate], 
                        [ExpirationDate], [Notes], [PaidFees], [IsActive], 
                        [IssueReason], [CreatedByUserID])
                     VALUES
                       (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, 
                        @ExpirationDate, @Notes, @PaidFees, @IsActive, 
                        @IssueReason, @CreatedByUserID);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

          
            if (string.IsNullOrEmpty(Notes))
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Notes", Notes);

            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                LicenseID = -1;
            }

            finally
            {
                connection.Close();
            }

            return LicenseID;
        }

     

        public static bool DiactivateLicense(int LicenseID, bool status)
        {
            SqlConnection conn = new SqlConnection(clsSettings.ConnectionString);

            string sql = "UPDATE Licenses SET [IsActive] = @Status WHERE LicenseID = @ID";
            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@ID", LicenseID);
            try
            {
                conn.Open();
               int rowEffected  = cmd.ExecuteNonQuery();

                return rowEffected > 0;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return false;
            }

            finally
            {
                conn.Close();
            }

        }





    }
}
