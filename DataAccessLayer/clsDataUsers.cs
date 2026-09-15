using Microsoft.Data.Sql;
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
    public class clsDataUsers
    {
        public static bool login(string username, string password,
            ref int personID, ref int UserID, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "select * from Users where Username=@username and PasswordHash=@password;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            bool isfound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    personID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    isActive = (bool)reader["IsActive"];




                    reader.Close();
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
            return isfound;
        }


        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT Users.UserID, Users.PersonID, FullName = People.FirstName + ' '  + People.SecondName + ' ' + People.ThirdName + ' ' +People.LastName, Users.UserName, Users.IsActive FROM   Users INNER JOIN   People ON Users.PersonID = People.PersonID";
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

        public static bool FindByUserID(int UserID, ref int personID, ref string username, ref string password, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT UserID, PersonID, UserName, PasswordHash, IsActive FROM Users WHERE UserID = @UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);

            bool isfound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    isActive = (bool)reader["IsActive"];

                    password = reader["PasswordHash"] != DBNull.Value ? reader["PasswordHash"].ToString() : "";
                    username = reader["UserName"] != DBNull.Value ? reader["UserName"].ToString() : "";

                    isfound = true; 
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
            return isfound;
        }


        public static bool Update(int UserID, int PersonID, string username, string password, bool IsActive)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
            {
                string query = "";

                
                if (string.IsNullOrEmpty(password))
                {
                    query = @"UPDATE Users 
                      SET PersonID = @PersonID, UserName = @UserName, IsActive = @IsActive 
                      WHERE UserID = @UserID";
                }
                else
                {
                    
                    query = @"UPDATE Users 
                      SET PersonID = @PersonID, UserName = @UserName, 
                          PasswordHash = @PasswordHash, IsActive = @IsActive 
                      WHERE UserID = @UserID";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                   
                    if (!string.IsNullOrEmpty(password))
                    {
                        command.Parameters.AddWithValue("@PasswordHash", password);
                    }

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch(Exception e) { EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error); }
                }
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteUserByID(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "delete Users where UserID=@UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

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
            finally
            {
                connection.Close();
            }
            
        }

        public static bool DoesUserExistsWithPersonID(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT TOP 1 1 FROM Users WHERE PersonID = @PersonID ;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
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

        public static bool DoesUserNameExists(string UserName)
        {


            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT TOP 1 1 FROM Users WHERE UserName= @UserName ;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
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

        public static  bool AddNewUser(ref int UserID,int PersonID, string username, string password, bool isActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "INSERT INTO Users (PersonID,UserName,Password,IsActive) values (@PersonID,@Username,@Password,@IsActive); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                    return true;
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }
            finally
            {
                connection.Close() ;
            }

            return false;
        }











    }
}
