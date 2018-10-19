using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class UserList
    {
        // Fields of the UserList class
        private List<User> users = new List<User>(); // List of user objects
        private List<string> userTypes = new List<string>() { "View", "Edit" }; // List of user types

        public List<string> UserTypes { get => userTypes; set => userTypes = value; }

        // Constructor
        public UserList(){
            LoadUsers("login.txt");
        }

        // LoadUsers() - Loads all users from the textfile database
        public void LoadUsers(string file)
        {
            StreamReader streamReader = new StreamReader(file);

            while (!streamReader.EndOfStream)
            {
                User user = new User();
                string line = streamReader.ReadLine();
                user.LoadUser(line);
                users.Add(user);
            }

            streamReader.Close();
        }

        // SaveUser() - Saves the data to the login.txt file
        public void SaveUser(string data)
        {
            File.AppendAllText(@"login.txt", data + Environment.NewLine);
        }

        // AddUser() - Adds a user to the list of users
        public void AddUser(User u)
        {
            users.Add(u);
        }

        // ValidUser() - Looks up if a user currently exists in the system
        public bool ValidUser(string username, string password)
        {
            foreach(var u in users)
            {
                if(u.Username == username && u.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        // User() - Returns the user with the matching username and password
        public User User(string username, string password)
        {
            foreach (var u in users)
            {
                if (u.Username == username && u.Password == password)
                {
                    return u;
                }
            }
            return null;
        }

        // UserNameIsFree() - Looks up if a new username is free to be used
        public bool UserNameIsFree(string username)
        {
            foreach(var u in users)
            {
                if(u.Username == username)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
