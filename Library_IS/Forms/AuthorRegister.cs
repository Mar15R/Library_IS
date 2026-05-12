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

namespace Library_IS.Forms
{
    public partial class AuthorRegister : Form
    {
        Factory factory = new Factory();
        public AuthorRegister()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            bool canSave = true;
            Author author = new Author
            {
                Name = txt_Name.Text,
                Surname = txt_Surname.Text
            };
            if(canSave)
            {
                factory.InsertAuthor(author);
                MessageBox.Show("Author added successfully!");
                this.Close();
            }

        }
    }
}
