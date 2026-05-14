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
    public partial class ReviewForm : Form
    {
        private string _userName;
        public ReviewForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }
        Factory factory = new Factory();

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            cb_Books.DataSource = factory.GetAllBooks();
            cb_Books.DisplayMember = "Book_Name";
            cb_Books.ValueMember = "ID_Book";
        }

        private void btn_SaveReview_Click(object sender, EventArgs e)
        {
            BookReview review = new BookReview
            {
                ID_Book = (long)cb_Books.SelectedValue,
                UserName = _userName,
                ReviewText = rt_Review.Text,
                Date_Time = DateTime.Now
            };
            factory.InsertBookReview(review);
            MessageBox.Show("Review saved successfully.");
            this.Close();
        }
    }
}
