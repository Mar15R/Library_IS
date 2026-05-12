using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS.Views
{
    public class AuthorView : Author
    {
        public string FullName => $"{Name} {Surname}";
    }
}
