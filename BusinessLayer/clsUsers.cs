using Projecr19_DataAccessLayer;
using Project_DataAccessLayer;
using Project19_BussnessLayer;
using System.Data;

namespace Project19_businessLayer
{
    public class clsUsers
    {
        enum enMode {AddNew =0, Update = 1 }
        enMode Mode;

        public  int UserID { get; set; }
        public int PersonID {  get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool isActive {  get; set; }


        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.userName = "";
            this.password = "";
           
            this.Mode = enMode.AddNew;
           
        }

        public clsUsers(int UserID, int PersonID, string userName, string password, bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.userName = userName;
            this.password = password;
            this.isActive = isActive;
               
        }


        public static clsUsers Login(string username,string password)
        {
           
            int PersonID =-1, UserID = -1;
            bool isActive = false;

            string hashedPassword = clsSecurityUtility.ComputeHash(password);

            if (clsDataUsers.login(username, hashedPassword, ref PersonID,ref UserID, ref isActive))
            {
                return new clsUsers(UserID, PersonID, username, password,isActive);
            }
            else
            {
                return null;
            }



        }

        public static clsUsers FindByID(int UserID)
        {
            int PersonID = -1;
            bool isActive = false;
            string username = "", password = "";

            if(clsDataUsers.FindByUserID(UserID,ref PersonID, ref username, ref password,ref isActive))
            {
                return new clsUsers(UserID, PersonID, username, "", isActive);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllUsers()
        {
            return  clsDataUsers.GetAllUsers();
        }

       public static bool Update(int UserID, int PersonID, string username, string Password,bool IsActive)
       {
            if (string.IsNullOrEmpty(Password))
            {
                return clsDataUsers.Update(UserID, PersonID, username, "", IsActive);
            }
            else
            {
               
                string hashedPassword = clsSecurityUtility.ComputeHash(Password);
                return clsDataUsers.Update(UserID, PersonID, username, hashedPassword, IsActive);
            }
        }

        public static bool DeleteUser(int UserID)
        {
            return clsDataUsers.DeleteUserByID(UserID);
        }

        public static bool DoesUserExistsWithPersonID(int PersonID)
        {
            return clsDataUsers.DoesUserExistsWithPersonID(PersonID);
        }

        public static bool DoesUserNameExists(string UserName)
        {
            return clsDataUsers.DoesUserNameExists(UserName);
        }

        public static bool AddNewUser(ref  int UserID, int PersonID ,string UserName,string password, bool isActive)
        {
            return clsDataUsers.AddNewUser(ref  UserID,PersonID,UserName, clsSecurityUtility.ComputeHash(password) , isActive);
        }


        public static void MigrateAllPasswordsToHash()
        {
            // 1. Fetch all users from the database 
            // (Assuming you have a method like GetAllUsers that returns a DataTable or List)
            DataTable dtUsers = clsUsers.GetAllUsers();

            foreach (DataRow row in dtUsers.Rows)
            {
                int userId = Convert.ToInt32(row["UserID"]);

                // Read the plain text from the column you renamed in SQL
                string plainTextPassword = row["PasswordPlaintext"].ToString();

                // 2. Convert it to a SHA-256 Hash using your static utility
                string hashedPassword = clsSecurityUtility.ComputeHash(plainTextPassword);

                // 3. Save it into the new PasswordHash column
                clsDataMigrationData.UpdateUserPasswordHash(userId, hashedPassword);
            }
        }

    }
}
