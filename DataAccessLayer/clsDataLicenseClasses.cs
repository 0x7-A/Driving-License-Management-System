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
    public class clsDataLicenseClasses
    {

        public static DataTable GetClassesNameAndID()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select LicenseClassID,ClassName from LicenseClasses ;";
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return null;
            }

            finally
            {
                connection.Close();
            }
                
            return dt;

        }

        public static bool GetClassLicenseIDUsingClassName(string className, ref int  ClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "select top 1 LicenseClassID from LicenseClasses where ClassName=@ClassName;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ClassName", className);


            try
            {
                connection.Open();
               object result = cmd.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out ClassID))
                {

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


        public static bool GetClassNameUsingClassID( int LicenseClassID, ref string className)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "select top 1  ClassName from LicenseClasses where LicenseClassID=@LicenseClassID;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    className = result.ToString().Trim();
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


        public static bool GetClassInfoByLicenseID(int LicenseClassID,
     ref string ClassName, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT ClassName, DefaultValidityLength, ClassFees
                         FROM LicenseClasses
                         WHERE LicenseClassID = @LicenseClassID";
           
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ClassName = (string)reader["ClassName"];
                    DefaultValidityLength = (byte) reader["DefaultValidityLength"];
                    ClassFees = (decimal) reader["ClassFees"];
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
                connection.Close() ;
            }
            

            
            
            return isFound;
        }





    }
}
