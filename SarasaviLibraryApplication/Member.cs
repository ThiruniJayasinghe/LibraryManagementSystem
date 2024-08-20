using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibraryApplication
{
    public class Member
    {
        public string UserNumber { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string NationalID { get; set; }
        public string Address { get; set; }
        public bool IsVisitor { get; set; }
        public List<BookCopy> BorrowedBooks { get; set; }

        
    }
}

