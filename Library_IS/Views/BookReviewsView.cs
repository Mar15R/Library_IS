using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS.Views
{
    public class BookReviewsView
    {

        public long Id_Review { get; set; }
        public string BookName { get; set; }
        public string UserFullName { get; set; }
        public string ReviewText { get; set; }
        public System.DateTime DateTime { get; set; }

    }
}
