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
    public partial class ReservationForm : Form
    {
        private Library library;

        public ReservationForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into ReserveTable values (@ID,@CopyID)", con);
            cmd.Parameters.AddWithValue("@ID", (txtUserNumber.Text));
            cmd.Parameters.AddWithValue("@CopyID", int.Parse(txtTitle.Text));


            cmd.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("Successfully Saved");
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();  //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from ReserveTable where ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", (txtUserNumber.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Displaying Old reservations");
        }

        private void btnBookD_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete ReserveTable where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", (txtUserNumber.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully deleted");
        }
    }

}

