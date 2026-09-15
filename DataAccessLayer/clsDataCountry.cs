using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    public class clsDataCountry
    {

        public static DataTable GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            DataTable dt = new DataTable();
            string query = "select * from Countries ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

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

        public static int GetCountryID(string CountryName)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "select top 1 CountryID from Countries where CountryName =@CountryName ;";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                object Result = cmd.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    return ID;
                else
                    return -1;

            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return -1;
            }

            finally
            {
                connection.Close();
            }
            return -1;
        }
    

        // GetCountryByName
    }   
}

