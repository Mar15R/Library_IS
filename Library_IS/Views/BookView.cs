using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS.Views
{
    public class BookView
    {
        public long ID_Book { get; set; }
            public string Book_Name { get; set; }
            public string ISBN { get; set; }
            public short Year { get; set; }
            //public Nullable<long> ID_Author { get; set; }
            public string AuthorName { get; set; } = string.Empty;
        //public string UserBook { get; set; }
    }
}
