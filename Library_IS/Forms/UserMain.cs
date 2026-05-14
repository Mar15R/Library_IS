using Library_IS.Lib;
using Library_IS.Views;
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
    public partial class UserMain : Form
    {
        Helper helper = new Helper();
        Factory factory = new Factory();
        private User _user;
        public UserMain(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UserMain_Load(object sender, EventArgs e)
        {

            ReloadData();
        }

        private void gv_Available_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var availableBooks = (BookView)gv_Available.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == gv_Available.Columns["btnTake"].Index)
            {
                if (factory.TakeBook(_user.UserName, availableBooks.ID_Book))
                {
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Error while taking book");
                }

            }
        }
        private void ReloadData()
        {
            helper.ReloadGrid(gv_Available, factory.GetAvailableBooks(), null, true, false, false);
            helper.ReloadGrid(gv_UserBooks, factory.GetUserBooks(_user.UserName), null, false, true, false);
            helper.ReloadGrid(gv_BookReviews, factory.GetAllBooksReview(), null, false, false, true);

        }

        private void gv_UserBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var userBooks = (BookView)gv_UserBooks.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == gv_UserBooks.Columns["btnReturn"].Index)
            {
                if (factory.ReturnBook(_user.UserName, userBooks.ID_Book))
                {
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Error while returning book");
                }

            }
        }

        private void btn_AddReview_Click(object sender, EventArgs e)
        {
            using (ReviewForm popup = new ReviewForm(_user.UserName))
            {
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ShowDialog(this);
                helper.ReloadGrid(gv_BookReviews, factory.GetAllBooksReview(), null, false, false, true);
            }
        }

        private void gv_BookReviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;


            if (gv_BookReviews.Columns[e.ColumnIndex].Name == "btnOpen")
            {

                var bookReview = (BookReviewsView)gv_BookReviews.Rows[e.RowIndex].DataBoundItem;

                if (bookReview != null)
                {

                    BookReviewForma detalizetaForma = new BookReviewForma();

                    detalizetaForma.IeladetDatus(
                        bookReview.UserFullName,
                        bookReview.DateTime.ToString("dd.MM.yyyy HH:mm"),
                        bookReview.ReviewText,
                        bookReview.BookName
                    );


                    detalizetaForma.ShowDialog();
                }
            }
        }
    }
}
