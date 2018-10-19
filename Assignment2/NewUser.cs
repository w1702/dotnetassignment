using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class NewUser : Form
    {
        // Fields of NewUser partial class
        private UserList userList;

        // Constructor
        public NewUser(UserList u)
        {
            InitializeComponent();
            
            userList = u;

            // Bind ComboBox options to usertypes list
            UserTypeCmbBx.DataSource = userList.UserTypes;
            // Format DatePicker
            DateOfBirthDTP.CustomFormat = "dd-MM-yyyy";
        }

        // SubmitBtn_Click() - When submit button is clicked, check if form is valid and add the new user, otherwise print error 
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                AddUser();
            }
            else
            {
                PrintError();
            }
        }

        // FormIsValid() - Calls all form validation functions, returns true if form is valid
        private bool FormIsValid()
        {
            return(FieldsNotEmpty() && UsernameIsFree() && PasswordsMatch());
        }

        // FieldsNotEmpty() - Checks to see if username, password, firstname and lastname fields are empty
        private bool FieldsNotEmpty()
        {
            return (UsernameTb.Text != "" && PasswordTb.Text != "" && FirstNameTb.Text != "" && LastNameTb.Text != "");
        }

        // UsernameIsFree() - Checks to see if new username is free to be used
        private bool UsernameIsFree()
        {
            return userList.UserNameIsFree(UsernameTb.Text);
        }

        // PasswordsMatch() - Checks to see if password field and re-enter password field match
        private bool PasswordsMatch()
        {
            return PasswordTb.Text == ReEnterPasswordTb.Text;
        }

        // AddUser() - Adds a user to user list and the login.txt file, shows confirmation if user is added
        private void AddUser()
        {
            string dataRow = UsernameTb.Text + "," + PasswordTb.Text + "," + UserTypeCmbBx.Text + "," + FirstNameTb.Text + "," + LastNameTb.Text + "," + DateOfBirthDTP.Text;
            User user = new User(UsernameTb.Text, PasswordTb.Text, FirstNameTb.Text, LastNameTb.Text, DateOfBirthDTP.Text, UserTypeCmbBx.Text);

            userList.AddUser(user);
            userList.SaveUser(dataRow);

            MessageBox.Show("Account created, welcome " + UsernameTb.Text);
            HideWindow();
        }

        // PrintError() - Prints an error message stating why form is invalid
        private void PrintError()
        {
            if (!FieldsNotEmpty())
            {
                MessageBox.Show("One or more fields are empty.");
            }
            else if (!UsernameIsFree())
            {
                MessageBox.Show("Username already exists, try something else.");
            }
            else if (!PasswordsMatch())
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

        // CancelBtn_Click() - Closes the window if button is clicked
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            HideWindow();
        }

        // HideWindow() = Hide the current window and returns to the login screen
        private void HideWindow()
        {
            Login login = new Login(userList);
            login.Show();
            this.Hide();
        }

        // NewUser_FormClosed() - On closing window, exit the application
        private void NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
