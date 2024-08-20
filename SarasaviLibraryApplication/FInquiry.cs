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
    public partial class FInquiry : Form
    {
        private Library library;

        public FInquiry(Library library)
        {
            InitializeComponent();
            this.library = library;
        }



        private void btnSearch_Click_1(object sender, EventArgs e)
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

        private void btnR_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();  //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from ReserveTable where ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", (txtTitle.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();  //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from LoanTable where ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", (txtTitle.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

