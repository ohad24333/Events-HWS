using Events3Bank.Librery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events3Bank.Ui
{
    public partial class Form1 : Form
    {
        UserManager userManager = new UserManager();

        public Form1()
        {
            InitializeComponent();
            userManager.UnSuccessLoginEvent += (object sender, string messege) => MessageBox.Show(messege);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userManager.Login(txtUserName.Text, txtPassword.Text);
        }
    }
}
