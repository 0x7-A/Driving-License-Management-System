using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Project_DataAccessLayer
{
    public class clsDataDetainLicense
    {

       public static bool  GetDetainedLicenseInfoByLicenseID(int LicenseID,
                ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
                ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int  ReleaseApplicationID)
        {



            bool isFound = false;

           
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT TOP 1 * FROM DetainedLicenses 
                         WHERE LicenseID = @LicenseID 
                         ORDER BY DetainID DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    

                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    else
                        ReleaseDate = DateTime.Now; 

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1; 

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                isFound  = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

    

       

        public static bool AddNew(ref int DetainID, int LicenseID, DateTime DetainDate,
    decimal FineFees, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[DetainedLicenses]
                       ([LicenseID], [DetainDate], [FineFees], [CreatedByUserID], [IsReleased])
                     VALUES
                       (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
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


        public static bool ReleaseDetainedLicense(int DetainID,
    int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

           
            string query = @"UPDATE [dbo].[DetainedLicenses]
                     SET IsReleased = 1, 
                         ReleaseDate = @ReleaseDate, 
                         ReleasedByUserID = @ReleasedByUserID, 
                         ReleaseApplicationID = @ReleaseApplicationID
                     WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now); 

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

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 
                            DetainedLicenses.DetainID AS [D.ID], 
                            DetainedLicenses.LicenseID AS [L.ID], 
                            DetainedLicenses.DetainDate AS [D.Date], 
                            DetainedLicenses.IsReleased, 
                            DetainedLicenses.FineFees, 
                            DetainedLicenses.ReleaseDate, 
                            People.NationalNo AS [N.No.], 
                            (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName) AS FullName,
                            DetainedLicenses.ReleaseApplicationID AS [Release App.ID]
                         FROM DetainedLicenses 
                         INNER JOIN Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID 
                         INNER JOIN Applications ON Licenses.ApplicationID = Applications.ApplicationID 
                         INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID
                         ORDER BY DetainedLicenses.DetainID DESC"; 

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
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




    }

}
