using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibraryApplication
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        private List<Loan> loans = new List<Loan>();
        private List<Reservation> reservations = new List<Reservation>();

        // Book registration
        public string RegisterBook(string title, string author, string isbn, bool isReference, int numberOfCopies)
        {
            // Register new book and add to the collection
            var book = new Book { Title = title, Author = author, ISBN = isbn, IsReference = isReference };
            for (int i = 1; i <= numberOfCopies; i++)
            {
                book.Copies.Add(new Copy { CopyID = $"{isbn}-{i}" });
            }
            books.Add(book);
            return "Book registered successfully.";
        }

        // User registration
        public string RegisterUser(string userNumber, string name, string sex, string nationalID, string address)
        {
            // Register new user and add to the collection
            var user = new User { UserNumber = userNumber, Name = name, Sex = sex, NationalID = nationalID, Address = address };
            users.Add(user);
            return "User registered successfully.";
        }

        // Book reservation
        public string ReserveBook(string userNumber, string copyID)
        {
            // Find user by user number
            var user = users.FirstOrDefault(u => u.UserNumber == userNumber);
            if (user == null) return "User not found.";

            // Find the book containing the copyID
            var book = books.FirstOrDefault(b => b.Copies.Any(c => c.CopyID == copyID));
            if (book == null) return "Book not found.";

            // Check if the book is already reserved
            var existingReservation = reservations.FirstOrDefault(r => r.CopyID == copyID);
            if (existingReservation != null) return "Book already reserved.";

            // Create and add reservation
            var reservation = new Reservation { User = user, Book = book, CopyID = copyID };
            reservations.Add(reservation);
            return "Book reserved successfully.";
        }

       

        // Book return
        public string ReturnBook(string copyID)
        {
            // Find the book containing the copyID
            var book = books.FirstOrDefault(b => b.Copies.Any(c => c.CopyID == copyID));
            if (book == null) return "Book copy not found.";

            // Check if the copy is reserved
            var reservation = reservations.FirstOrDefault(r => r.CopyID == copyID);
            if (reservation != null)
            {
                // Notify the user who reserved the book

                reservations.Remove(reservation);
                return $"Book returned successfully. The copy was reserved for user {reservation.User.Name}.";
            }


            // For simplicity, assuming the copy is just removed from the list of copies
            var copy = book.Copies.First(c => c.CopyID == copyID);
            book.Copies.Remove(copy);

            return "Book returned successfully.";
        }

        public string LoanBook(string userNumber, string copyID)
        {
            // Find user by user number
            var user = users.FirstOrDefault(u => u.UserNumber == userNumber);
            if (user == null) return "User not found.";

            // Find the book containing the copyID
            var book = books.FirstOrDefault(b => b.Copies.Any(c => c.CopyID == copyID));
            if (book == null) return "Book not found.";

            // Check if the copy is already on loan
            var existingLoan = loans.FirstOrDefault(l => l.CopyID == copyID);
            if (existingLoan != null) return "Book already on loan.";

            // Create and add loan
            var loan = new Loan { User = user, Book = book, CopyID = copyID };
            loans.Add(loan);

            // Remove the copy from the book's list of available copies
            var copy = book.Copies.FirstOrDefault(c => c.CopyID == copyID);
            book.Copies.Remove(copy);

            return "Book loaned successfully.";
        }

    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsReference { get; set; }
        public List<Copy> Copies { get; set; } = new List<Copy>();
    }

    public class User
    {
        public string UserNumber { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string NationalID { get; set; }
        public string Address { get; set; }
    }

    public class Reservation
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public string CopyID { get; set; }
    }

    public class Copy
    {
        public string CopyID { get; set; }
    }

    public class Loan
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public string CopyID { get; set; }
    }

}

