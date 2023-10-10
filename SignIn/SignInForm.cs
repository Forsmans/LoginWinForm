using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForms signUp = new SignUpForms();
            signUp.Show();
        }
        public void logInButton_Click(object sender, EventArgs e)
        {
            User loggedInUser = User.CheckUserLogin(usernameBox.Text, passwordBox.Text);

            if (loggedInUser != null)
            {
                ProgramForm program = new ProgramForm(loggedInUser);

                MessageBox.Show($"Login successful.");

                this.Hide();
                program.Show();
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }
    }
}
