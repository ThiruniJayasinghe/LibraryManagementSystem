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
using System.Xml.Linq;

namespace SarasaviLibraryApplication
{
    public partial class UserRegistrationF : Form
    {
        private Library library;

        public UserRegistrationF(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into UserTable values (@ID,@Name,@Gender,@NationalID,@Address)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtUserNumber.Text));
            cmd.Parameters.AddWithValue("@Name", (txtName.Text));
            cmd.Parameters.AddWithValue("@Gender", (textBox1.Text));
            cmd.Parameters.AddWithValue("@NationalID", (txtNationalID.Text));
            cmd.Parameters.AddWithValue("@Address", (txtAddress.Text));

            cmd.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("Successfully Registered");
        }

        private void btnFind_Click(object sender, EventArgs e)
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

        private void btnupdate(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserTable set Name=@Name, Gender=@Gender , NationalID=@NationalID , Address=@Address where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtUserNumber.Text));
            cmd.Parameters.AddWithValue("@Name", (txtName.Text));
            cmd.Parameters.AddWithValue("@Gender", (textBox1.Text));
            cmd.Parameters.AddWithValue("@NationalID", (txtNationalID.Text));
            cmd.Parameters.AddWithValue("@Address", (txtAddress.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Updated");
        }

        private void btndelete(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OOMCMQ7\\SQLEXPRESS;Initial Catalog=libraryDatabase;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete UserTable where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtUserNumber.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully deleted");
        }
    }
}

