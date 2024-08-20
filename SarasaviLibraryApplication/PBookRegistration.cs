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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SarasaviLibraryApplication
{
    public partial class PBookRegistration : Form
    {
        private Library library;

        public PBookRegistration(Library library)
        {
            InitializeComponent();
            this.library = library;
        }


        //search the data
        private void btncheck_Click(object sender, EventArgs e)
        {

            //connect the database
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open(); //open the connection

            //select the data from table
            SqlCommand cmd = new SqlCommand("Select * from BookTable where ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", (txtTitle.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //register button
        private void btnBookRegister_Click(object sender, EventArgs e)
        {

            //validation of number of copies
            int numberOfCopies;
            if (!int.TryParse(txtNumberOfCopies.Text, out numberOfCopies) || numberOfCopies > 10)
            {
                MessageBox.Show("The value of number of copies must not exceed 10 copies");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into BookTable values (@ID,@Author,@Title,@NumberOfCopies,@RefORBorrow)", con);
            cmd.Parameters.AddWithValue("@ID", (txtTitle.Text));
            cmd.Parameters.AddWithValue("@Author", (txtAuthor.Text));
            cmd.Parameters.AddWithValue("@Title", (txtISBN.Text));
            cmd.Parameters.AddWithValue("@NumberOfCopies", int.Parse(txtNumberOfCopies.Text));
            cmd.Parameters.AddWithValue("@RefORBorrow", (textBox1.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Registered");

        }

        //update button
        private void button2_Click(object sender, EventArgs e)
        {

            //validation of number of copies
            int numberOfCopies;
            if (!int.TryParse(txtNumberOfCopies.Text, out numberOfCopies) || numberOfCopies > 10)
            {
                MessageBox.Show("Number of copies must be a valid number and not exceed 10.");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update BookTable set Author=@Author, Title=@Title , NumberOfCopies=@NumberOfCopies , RefORBorrow=@RefORBorrow where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", (txtTitle.Text));
            cmd.Parameters.AddWithValue("@Author", (txtAuthor.Text));
            cmd.Parameters.AddWithValue("@Title", (txtISBN.Text));
            cmd.Parameters.AddWithValue("@NumberOfCopies", int.Parse(txtNumberOfCopies.Text));
            cmd.Parameters.AddWithValue("@RefORBorrow", (textBox1.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Updated");
        }

        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete BookTable where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", (txtTitle.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully deleted");
        }
    }
}

