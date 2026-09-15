using Projecr19_DataAccessLayer;
using Project19_businessLayer;
using System.Data;
using System.Security.Cryptography;
using System.Text;


namespace Project19_BussnessLayer
{
    public static class clsSecurityUtility
    {

       public static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

        }

        public static void MigrateAllPasswordsToHash()
        {
            // Option B implementation: Calls our safe, dedicated migration query
            DataTable dtUsers = clsDataMigrationData.GetAllUsersForMigration();

            foreach (DataRow row in dtUsers.Rows)
            {
                int userId = Convert.ToInt32(row["UserID"]);
                string plainTextPassword = row["PasswordPlaintext"].ToString();

                // Generate hash
                string hashedPassword = ComputeHash(plainTextPassword);

                // Save hash into the database
                clsDataMigrationData.UpdateUserPasswordHash(userId, hashedPassword);
            }
        }



    }
}
