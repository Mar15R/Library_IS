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
    public partial class BookReviewForma : Form
    {
        public BookReviewForma()
        {
            InitializeComponent();
        }

        private void BookReview_Load(object sender, EventArgs e)
        {

        }

        public void IeladetDatus(string lietotajs, string datums, string teksts, string gramata)
        {
            lb_User.Text = $"Autors: {lietotajs}";
            lb_DateTime.Text = $"Datums: {datums}";
            lb_BookName.Text = $"Grāmata: {gramata}";
            txt_Review.Text = teksts; 
        }
    }
}
