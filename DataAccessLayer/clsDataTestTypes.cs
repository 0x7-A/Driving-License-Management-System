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
    public class clsDataTestTypes
    {
        public static DataTable GetAllTestType()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes;";

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

        public static bool FindTestTypeByID(int TestTypeID, ref string TestTypeTitle,
            ref string TestTypeDescription, ref decimal fee)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes where TestTypeID=@TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            bool isFound = false;
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    fee = (decimal) reader["TestTypeFees"];

                    reader.Close();
                    isFound = true;
                }



            }
            catch (Exception e) { EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error); }
            finally
            { 
              
                connection.Close();
            }
            return isFound;
        }

     
        public static bool Update(int TestTypeID,string TestTypeTitle,
             string TestTypeDescription,  decimal fee)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "update TestTypes set TestTypeTitle=@TestTypeTitle," +
                " TestTypeDescription=@TestTypeDescription, TestTypeFees =@TestTypeFees where TestTypeID =@TestTypeID ; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeTitle",TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeDescription",TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees",fee);
            cmd.Parameters.AddWithValue("@TestTypeID",TestTypeID);


            try
            {
                connection.Open();
                return cmd.ExecuteNonQuery() > 0;

            }
            catch (Exception e)
            { 
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }
            finally { connection.Close(); }


            return false;
        }

    }
}
