using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibraryApplication
{
    public class BookTitle
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsReference { get; set; }
        public List<BookCopy> Copies { get; set; }

        public BookTitle(string title, string author, string isbn, bool isReference)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsReference = isReference;
            Copies = new List<BookCopy>();
        }
    }
}

