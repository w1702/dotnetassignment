using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Login : Form
    {
        // Fields of Login partial class
        private UserList userList;

        // Constructor
        public Login(UserList u)
        {
            InitializeComponent();
            userList = u;
        }

        // NewUserBtn_Click() - Create a new user with the NewUser form
        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(userList);
            newUser.Show();
            this.Hide();
        }

        // LoginBtn_Click() - Login to the text editor
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string password = PasswordTb.Text;
            // need to check if username exists
            if (userList.ValidUser(username, password))
            {
                TextEditor textEditor = new TextEditor(userList, userList.User(username, password));
                textEditor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unknown username or incorrect password!");
            }
        }

        // ExitBtn_Click() - Exit the application
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Login_FormClosed() - On closing window, Exit the application
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
