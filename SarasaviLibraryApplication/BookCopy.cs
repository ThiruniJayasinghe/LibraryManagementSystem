using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibraryApplication
{
    public class BookCopy
    {
        public string CopyID { get; set; }
        public bool IsBorrowed { get; set; }
        public bool IsReserved { get; set; }
        public DateTime? DueDate { get; set; }

        public BookCopy(string copyID)
        {
            CopyID = copyID;
            IsBorrowed = false;
            IsReserved = false;
            DueDate = null;
        }
    }
}

