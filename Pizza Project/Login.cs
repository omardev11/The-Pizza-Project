using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("The Gamil and name can not be empty");
            }
            else
            {
                GlobalSetting.Email = txtUserName.Text;
                GlobalSetting.Name = txtPassword.Text;
                Form1 form1 = new Form1();
                form1.ShowDialog();
                
            }
        }
    }
}
