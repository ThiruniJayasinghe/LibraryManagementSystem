using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibraryApplication
{
    public partial class MainForm : Form
    {
        private Library library;

        public MainForm()
        {
            InitializeComponent();
            library = new Library();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            LoanF loanForm = new LoanF(library);
            loanForm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm(library);
            returnForm.ShowDialog();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm(library);
            reservationForm.ShowDialog();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            FInquiry inquiryForm = new FInquiry(library);
            inquiryForm.ShowDialog();
        }

        private void btnBookRegistration_Click(object sender, EventArgs e)
        {
            PBookRegistration bookRegistrationForm = new PBookRegistration(library);
            bookRegistrationForm.ShowDialog();
        }

        private void btnUserRegistration_Click(object sender, EventArgs e)
        {
            UserRegistrationF userRegistrationForm = new UserRegistrationF(library);
            userRegistrationForm.ShowDialog();
        }
    }
}

