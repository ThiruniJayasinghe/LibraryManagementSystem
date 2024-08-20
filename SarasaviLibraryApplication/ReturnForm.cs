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
    public partial class ReturnForm : Form
    {
        private Library library;

        public ReturnForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

       

        private void btnReturnT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into ReturnTable values (@ID,@UserNumber)", con);
            cmd.Parameters.AddWithValue("@ID", (txtCopyID.Text));
            cmd.Parameters.AddWithValue("@UserNumber", int.Parse(txtUserNumber.Text));


            cmd.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("Successfully Returned");
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();  //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from ReserveTable where ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", (txtCopyID.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();  //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from UserTable where ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(txtUserNumber.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}

