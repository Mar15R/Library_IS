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
using System.Text.RegularExpressions;

namespace Library_IS.Forms
{
    public partial class UserRegister : Form
    {
        Factory factory = new Factory();
        public UserRegister()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            bool canSave = true;
            if (factory.IsUserNameTaken(txt_Username.Text))
            {
                lb_Error.Text = "Username is already taken!";
                canSave = false;
            }
            if (string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text) || string.IsNullOrWhiteSpace(txt_PasswordRepeat.Text) || string.IsNullOrWhiteSpace(txt_Name.Text) || string.IsNullOrWhiteSpace(txt_Surname.Text) || string.IsNullOrWhiteSpace(txt_Email.Text) || string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                lb_Error.Text = "All fields are required!";
                canSave = false;
            }
            if (txt_Password.Text != txt_PasswordRepeat.Text)
            {
                lb_Error.Text = "Passwords do not match!";
                canSave = false;
            }
            const string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            if (!Regex.IsMatch(txt_Password.Text, passwordPattern))
            {
                lb_Error.Text = "Password must be at least 8 characters long and include uppercase, lowercase, digit and special character.";
                canSave = false;
            }

            // Password strength/regex check: require at least 8 chars, one uppercase, one lowercase, one digit and one special char

            const string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txt_Email.Text, emailPattern))
            {
                lb_Error.Text = "Invalid email format.";
                canSave = false;
            }

            if (canSave)
            {
                User user = new User
                {
                    Name = txt_Name.Text,
                    Surname = txt_Surname.Text,
                    Email = txt_Email.Text,
                    Phone = txt_Phone.Text,
                    Role = "User",
                    Password = txt_Password.Text,
                    UserName = txt_Username.Text
                };
                factory.InsertUser(user);
                this.Close();
            }
        }
    }
}
