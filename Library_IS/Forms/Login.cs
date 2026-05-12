using Library_IS.Forms;
using Library_IS.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS
{
    public partial class Login : Form
    {
        Factory factory = new Factory();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            using (UserRegister popup = new UserRegister())
            {
                popup.ShowDialog();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            User user = factory.AuthenticateUser(username, password);
            if (user != null)
            {

                if (user.Role == "Admin")
                {
                    this.Hide();
                    AdminMain adminPanel = new AdminMain();
                    adminPanel.ShowDialog();
                    this.Close();
                }
                else if (user.Role == "User")
                {
                    this.Hide();
                    UserMain userPanel = new UserMain(user);
                    userPanel.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }



            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Username.Text = "LBalode";
            txt_Password.Text = "LBalode1!";
        }
    }
}
