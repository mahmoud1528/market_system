using Microsoft.Data.SqlClient;
using System;

namespace WinFormsApp1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "" && textBox2.Text == "")
             {
                 MessageBox.Show("Please enter your name and phone number");
             }
             else if (textBox1.Text == null || textBox1.Text == "")
             {
                 MessageBox.Show("Please enter your name");
             }
             else if (textBox2.Text == null || textBox2.Text == "")
             {
                 MessageBox.Show("Please enter your phone number");
             }
             else if (textBox2.Text.Length < 11 || textBox2.Text.Length > 11)
             {
                 MessageBox.Show("Phone number must be 11 numbers");
             }
             else
             {
                 string tb1 = textBox1.Text;
                     Order f2 = new Order(tb1);
                     f2.mytextbox.ReadOnly = true;
                     f2.ShowDialog();
                     f2.Show();
                     this.Hide();
                SqlConnection sq = new SqlConnection("Data Source=MAHMOUD;Initial Catalog=Supermarkets;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                sq.Open();
                string insertqueryitems = "INSERT INTO customer(Name,phone) VALUES ( @Name, @phone)";

                SqlCommand cmd = new SqlCommand(insertqueryitems, sq);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@phone", textBox2.Text);
                //cmd.Parameters.AddWithValue("@Cid", "10");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Has Been Added Succesfully", "info", MessageBoxButtons.OK);
                sq.Close();
            }

         
            
          

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}