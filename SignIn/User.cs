using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn
{
    internal class User
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

        public void SaveUserToTxt(User user)
        {
            string filePath = "userslogins.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write($"{user.FirstName},");
                writer.Write($"{user.LastName},");
                writer.Write($"{user.Username},");
                writer.Write($"{user.Password}");
                writer.WriteLine();
            }
        }

        public static User CheckUserLogin(string username, string password)
        {
            string filePath = "userslogins.txt";

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] userData = line.Split(',');

                if(userData.Length == 4)
                {
                    string firstName = userData[0];
                    string lastName = userData[1];
                    string storedUsername = userData[2];
                    string storedPassword = userData[3];

                    if(storedUsername == username && storedPassword == password)
                    {
                        return new User(firstName, lastName, storedUsername, storedPassword);
                    }
                }
            }

            return null;
        }

    }
}
