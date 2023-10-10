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
    public partial class ProgramForm : Form
    {
        public ProgramForm(User user)
        {
            InitializeComponent();

            welcomeLabel.Text = $"Welcome {user.FirstName} {user.LastName}";


        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Start.startMenu.Show();
        }
    }
}
