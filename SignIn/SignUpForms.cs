using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SignIn
{
    public partial class SignUpForms : Form
    {
        new List<User> users = new List<User>();

        public SignUpForms()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            Start.signIn.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (firstNameBox.Text != "" && lastNameBox.Text != "" && usernameBox.Text != "" && passwordBox.Text != "")
            {
                User user = new User(firstNameBox.Text, lastNameBox.Text, usernameBox.Text, passwordBox.Text);

                if (user.IsUsernameTaken(user.Username))
                {
                    MessageBox.Show("Username is already taken. Please choose a different one.");
                }
                else
                {
                    user.SaveUserToTxt(user);
                    MessageBox.Show("Registration successful!");

                    this.Hide();
                    Start.signIn.Show();
                }
            }
            else
            {
                MessageBox.Show("All fields are not filled");
            }
        }







        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
        }

        
    }
}
