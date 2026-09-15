using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    public class clsDataPerson
    {
        public static DataTable GetAllPeople()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            DataTable dt = new DataTable();

            string query = "SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, CASE WHEN People.Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gendor, People.DateOfBirth, Countries.CountryName AS Nationality, People.Phone, People.Email FROM dbo.People INNER JOIN dbo.Countries ON People.NationalityCountryID = Countries.CountryID;";
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

        public static bool DeletePersonByID(int id)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "Delete from People where PersonID=@PersonID ;";

            SqlCommand cmd= new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", id);

            try
            {
                connection.Open();

                return cmd.ExecuteNonQuery() > 0;


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

        public static bool FindByID(int PersonID, ref string NationalNumber  , ref string FirstName, ref string SecondName, ref string  ThirdName,
            ref string LastName, DateTime DateOfBirth,ref int Gender, ref string Address, ref string phone, ref string Email, ref string ImagePath,ref string Nationility)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT Countries.CountryName, People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth,   CASE WHEN People.Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gender, People.Address, People.Phone, People.Email, People.ImagePath FROM People INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID  where PersonID= @PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID",PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    
                    NationalNumber = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if((string)reader["Gender"]=="Male")
                    {
                        Gender = 0;
                    }
                    else
                    {
                        Gender = 1;
                    }

                    phone = (string)reader["Phone"];
                    ThirdName = (reader["ThirdName"] == DBNull.Value) ? null : (string)reader["ThirdName"];
                    Email = (reader["Email"] == DBNull.Value) ? null : (string)reader["Email"];
                    ImagePath = reader["ImagePath"] == DBNull.Value ? null : (string)reader["ImagePath"];
                    Address = (string)reader["Address"];
                    Nationility = (string)reader["CountryName"];
                    reader.Close();
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

        public static bool Update(int PersonID,string NationalNumber, string FirstName, string SecondName, string ThirdName,
          string LastName, DateTime DateOfBirth,  int Gender, string Address  ,string phone, string Email, int CountryID, string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "update People set NationalNo=@NationalNo, FirstName=@FirstName, SecondName=@SecondName, ThirdName=@ThirdName, LastName=@LastName,DateOfBirth=@DateOfBirth, Gendor=@Gender, Address=@Address, Phone=@Phone, Email=@Email,NationalityCountryID=@NationalityCountryID, ImagePath=@ImagePath where  PersonID = @PersonID";



            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNumber);
            cmd.Parameters.AddWithValue("@FirstName",FirstName);
            cmd.Parameters.AddWithValue("@SecondName",SecondName);
    
            cmd.Parameters.AddWithValue("@LastName",LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender",Gender);
            cmd.Parameters.AddWithValue("@Address",Address);
            
            cmd.Parameters.AddWithValue("@Phone",phone);
            cmd.Parameters.AddWithValue("@NationalityCountryID", CountryID);
            
            cmd.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
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
        
        public static bool DoesPersonExistsByNationalNo(string NationalNumber)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "select top 1 1 from People where NationalNo=@NationalNo;";

          

            SqlCommand cmd  = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NationalNo",NationalNumber);
          
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
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

  

        public static bool AddNewPerson(ref int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName,
          string LastName, DateTime DateOfBirth, int Gender, string Address, string phone, string Email, int CountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath); SELECT SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(query, connection);

            
            command.Parameters.AddWithValue("@NationalNo", NationalNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);

            command.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
            command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
            command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID; 
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

        public static bool FindByNationalNumber(ref int PersonID,string NationalNumber, ref string FirstName, ref string SecondName, ref string ThirdName,
          ref string LastName, DateTime DateOfBirth, ref int Gender, ref string Address, ref string phone, ref string Email, ref string ImagePath, ref string Nationility)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT Countries.CountryName, People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth,   CASE WHEN People.Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gender, People.Address, People.Phone, People.Email, People.ImagePath FROM People INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID  where NationalNo=@NationalNo";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    PersonID = (int)reader["PersonID"];
                    NationalNumber = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if ((string)reader["Gender"] == "Male")
                    {
                        Gender = 0;
                    }
                    else
                    {
                        Gender = 1;
                    }

                    phone = (string)reader["Phone"];
                    ThirdName = (reader["ThirdName"] == DBNull.Value) ? null : (string)reader["ThirdName"];
                    Email = (reader["Email"] == DBNull.Value) ? null : (string)reader["Email"];
                    ImagePath = reader["ImagePath"] == DBNull.Value ? null : (string)reader["ImagePath"];
                    Address = (string)reader["Address"];
                    Nationility = (string)reader["CountryName"];
                    reader.Close();
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




        public static int GetPersonIDByDriverID(int DriverID)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

         
            string query = "SELECT PersonID FROM Drivers WHERE DriverID=@DriverID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int foundID))
                {
                    PersonID = foundID;
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

            return PersonID;
        }

    }


}
