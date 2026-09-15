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
    public class clsDataManageAppTypes
    {
        public static DataTable GetAllAppTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes;";

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


        public static bool UpdateAppType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
         SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

         string query = "UPDATE ApplicationTypes SET ApplicationTypeTitle=@ApplicationTypeTitle, ApplicationFees=@ApplicationFees where ApplicationTypeID=@ApplicationTypeID ";

         SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
           

            try
            {
                connection.Open();
               
               return cmd.ExecuteNonQuery() > 0;

                
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return false;
            }
            finally { connection.Close(); }
        }


        public static bool GetAppInfo(int ApplicationTypeID, ref decimal Fees, ref string description)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = @"SELECT * FROM  ApplicationTypes where ApplicationTypeID =@ApplicationTypeID;";
            SqlCommand cmd  =  new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    Fees = (decimal) reader["ApplicationFees"]  ;
                    description = (string)reader["ApplicationTypeTitle"];
                    reader.Close();
                    return true;
                }
               
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }
            finally { connection.Close(); 
            }
            return false;

        
 
        }





    }

}
