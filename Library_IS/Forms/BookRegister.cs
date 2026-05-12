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
    public partial class BookRegister : Form


    {
        Factory factory = new Factory();
        public BookRegister()
        {
            InitializeComponent();
        }

        private void BookRegister_Load(object sender, EventArgs e)
        {
            cb_Author.DataSource = factory.GetAllAuthors();
            cb_Author.DisplayMember = "FullName";
            cb_Author.ValueMember = "ID_Author";
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            bool canSave = true;
            Book book = new Book
            {
                Book_Name    = txt_BookName.Text,
               ISBN         = txt_ISBN.Text,
                Year         = short.Parse(txt_Year.Text),
                ID_Author = (long)cb_Author.SelectedValue
            };
            if (canSave)
            {
                factory.InsertBook(book);
                MessageBox.Show("Book registered successfully.");
                this.Close();
            }
        }

        private void btn_AddAuthor_Click(object sender, EventArgs e)
        {
            using(AuthorRegister popup = new AuthorRegister())
            {
                popup.ShowDialog();
                cb_Author.DataSource = factory.GetAllAuthors();
                cb_Author.DisplayMember = "FullName";
                cb_Author.ValueMember = "ID_Author";
            }
        }
    }
}
