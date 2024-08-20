using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibraryApplication
{
    public partial class LoanF : Form
    {
        private Library library;

        public LoanF(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        //Loan button
        private void btnLoan_Click(object sender, EventArgs e)
        {
            string userNumber = txtTitle.Text;
            string copyID = txtCopyID.Text;

            //connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();  //open the connection

            //insert data to the table
            SqlCommand cmd = new SqlCommand("Insert into LoanTable values (@ID,@UserNumber)", con);
            cmd.Parameters.AddWithValue("@ID", (txtTitle.Text));
            cmd.Parameters.AddWithValue("@UserNumber", int.Parse(txtCopyID.Text));

            cmd.ExecuteNonQuery(); //execute the query

            con.Close(); //close the database

            MessageBox.Show("Accept Loan"); //messege
        }

        //Available Books button
        private void btnAvavBooks_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();  //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from BookTable where ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", (txtTitle.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Available loans button
        private void btnAvaLoans_Click(object sender, EventArgs e)
        {

            //connect the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open(); //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from LoanTable where UserNumber=@UserNumber", con);
            cmd.Parameters.AddWithValue("UserNumber", (txtCopyID.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update LoanTable set UserNumber=@UserNumber where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", (txtTitle.Text));
            cmd.Parameters.AddWithValue("@UserNumber", int.Parse(txtCopyID.Text));


            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Updated");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete LoanTable where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", (txtTitle.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully deleted");
        }
    }
}

