using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter all fields (ID, Name, Age)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFQAM6G;Initial Catalog=CRUDForm;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into ut values(@id,@name,@age)", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(textBox3.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFQAM6G;Initial Catalog=CRUDForm;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update ut set name=@name, age=@age Where id=@id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(textBox3.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter ID to delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFQAM6G;Initial Catalog=CRUDForm;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from ut Where id=@id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter ID to search", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFQAM6G;Initial Catalog=CRUDForm;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From ut Where id=@id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
