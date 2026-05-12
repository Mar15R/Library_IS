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
using static Library_IS.Lib.Helper;

namespace Library_IS.Forms
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        Helper helper = new Helper();
        Factory factory = new Factory();

        List<GridAction> gridActions = new List<GridAction>
        {
             new GridAction { Name = "btnUpdate", Text = "Update" },
              new GridAction { Name = "btnDelete", Text = "Delete" },

        };
        private void gv_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Books = (BookView)gv_Books.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == gv_Books.Columns["btnDelete"].Index)
            {
                if (factory.DeleteBook(Books.ID_Book))
                {
                    helper.ReloadGrid(gv_Books, factory.GetAllBooks(), gridActions, new List<int>());
                }
                else
                {
                    MessageBox.Show("Error while deleting book");
                }
            }

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            //helper.ReloadGrid(gv_Books, factory.GetAllBooks, gridActions, new List<int>());
            helper.ReloadGrid(gv_Books, factory.GetAllBooks(), gridActions, new List<int>());
            helper.ReloadGrid(gv_Users, factory.GetAllUsers(), gridActions, new List<int>());

        }

        private void gv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = (UserView)gv_Users.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == gv_Users.Columns["btnDelete"].Index)
            {
                if (factory.DeleteUser(user.UserName))
                {
                    helper.ReloadGrid(gv_Users, factory.GetAllUsers(), gridActions, new List<int>());
                }
                else
                {
                    MessageBox.Show("Error while deleting user");
                }
            }
        }

        private void btn_RegisterBook_Click(object sender, EventArgs e)
        {
            using (BookRegister popup = new BookRegister())
            {
                popup.ShowDialog();
                helper.ReloadGrid(gv_Books, factory.GetAllBooks(), gridActions, new List<int>());
            }
        }
    }
}
