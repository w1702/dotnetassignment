using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class User
    {
        // Fields of the User class
        private string username, password, firstName, lastName, dateOfBirth, userType;

        // Constructors
        // For loading users
        public User() { }
        // For adding users
        public User(string username, string password, string firstName, string lastName, string dateOfBirth, string userType)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.userType = userType;
        }

        // LoadUser() - Assigns values to fields of user
        public void LoadUser(string line)
        {
            string[] fields = line.Split(',');

            username = fields[0];
            password = fields[1];
            userType = fields[2];
            firstName = fields[3];
            lastName = fields[4];
            dateOfBirth = fields[5];
 
        }

        // Properties
        public string Username { get => username; }
        public string Password { get => password; }
        public string UserType { get => userType; }
    }
}
