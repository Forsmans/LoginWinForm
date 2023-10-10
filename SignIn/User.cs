using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SignIn
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public void SaveUserToTxt(User user)
        {
            string filePath = "userslogins.txt";

            if (IsUsernameTaken(user.Username))
            {
                MessageBox.Show("Username is already taken. Please choose a different one.");
            }
            else
            {
                // Hash the user's password
                string hashedPassword = HashPassword(user.Password);

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write($"{user.FirstName},");
                    writer.Write($"{user.LastName},");
                    writer.Write($"{user.Username},");
                    writer.Write($"{hashedPassword}"); // Save the hashed password
                    writer.WriteLine();
                }
            }
        }



        public static User CheckUserLogin(string username, string password)
        {
            string filePath = "userslogins.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] userData = line.Split(',');

                    if (userData.Length == 4)
                    {
                        string firstName = userData[0];
                        string lastName = userData[1];
                        string storedUsername = userData[2];
                        string storedHashedPassword = userData[3]; 
                        
                        string inputHashedPassword = HashPassword(password);

                        if (storedUsername == username && storedHashedPassword == inputHashedPassword)
                        {
                            return new User(firstName, lastName, storedUsername, storedHashedPassword);
                        }
                    }
                }
            }

            return null;
        }

        public bool IsUsernameTaken(string username)
        {
            string filePath = "userslogins.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] userData = line.Split(',');

                    if (userData.Length >= 3)
                    {
                        string storedUsername = userData[2];

                        if (storedUsername == username)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }






    }
}
