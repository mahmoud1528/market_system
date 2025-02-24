/*using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Order : Form
    {
        SqlDataReader dr;
        private string rtb1;
        public TextBox mytextbox
        {
            get { return textBox1; }
        }
        public Order(string tb1)
        {
            InitializeComponent();
            rtb1 = tb1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=MAHMOUD;Initial Catalog=Supermarkets;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
       
            SqlCommand cmd = new SqlCommand("Select price from items where Name = @Name", sq);
            cmd.Parameters.AddWithValue("@Name",comboBox1.Text);
            sq.Open();
            dr =cmd.ExecuteReader();
            while (dr.Read())
            {
                string price = dr["price"].ToString(); 
                textBox1.Text= price;
            }
            sq.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            textBox1.Clear();

            textBox3.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string product = comboBox1.Text;
                int Piece = int.Parse(textBox1.Text);
                int Quantity = int.Parse(textBox3.Text);
                int Total_Price = (Piece * Quantity);

               
                    
                   
              
               
                
                    string message = "Name :" + rtb1 + Environment.NewLine + "Date : " + DateTime.Now.ToString("dd/MM/yyyy") + Environment.NewLine + "Product : " + product + Environment.NewLine + "Price/Piece : " + Piece + Environment.NewLine + "Quantity " + Quantity + Environment.NewLine + "Total Price : " + Total_Price;
                    MessageBox.Show(message);
                
            
           /* catch (FormatException ex)
            {
                MessageBox.Show("Please select product", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            register f1 = new register();
            f1.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=MAHMOUD;Initial Catalog=Supermarkets;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //comboBox1.Items.Clear();
            // sq.Open();
            SqlCommand cmd = new SqlCommand("Select Barcode,Name from items", sq);
            //cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "Select Barcode,Name from items";
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Barcode";

            // foreach (DataRow dr in dt.Rows)
            //{
            //  comboBox1.Items.Add(dr["Name"].ToString());
            //}
            //sq.Close();   
        }

        private void FillComb()
        {
          
                
        }
    }
}*/
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Order : Form
    {
        SqlDataReader dr;
        private string rtb1;

        public TextBox mytextbox
        {
            get { return textBox1; }
        }

        public Order(string tb1)
        {
            InitializeComponent();
            rtb1 = tb1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sq = new SqlConnection("Data Source=MAHMOUD;Initial Catalog=Supermarkets;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                SqlCommand cmd = new SqlCommand("Select price from items where Name = @Name", sq);
                cmd.Parameters.AddWithValue("@Name", comboBox1.Text);

                sq.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Retrieve the price as decimal and format it to two decimal places
                    if (dr["price"] != DBNull.Value && decimal.TryParse(dr["price"].ToString(), out decimal price))
                    {
                        textBox1.Text = price.ToString("F2"); // Format as a string with 2 decimal places
                    }
                    else
                    {
                        textBox1.Text = "Invalid Price";
                        MessageBox.Show("The price retrieved from the database is invalid.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    textBox1.Text = "Price not found";
                }

                dr.Close();
                sq.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Please select a product.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBox1.Text, out decimal piece) || piece <= 0)
                {
                    MessageBox.Show("Invalid price. Please ensure the price is a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Invalid quantity. Please enter a valid number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalPrice = piece * quantity;

                string message = $"Name: {rtb1}{Environment.NewLine}" +
                                 $"Date: {DateTime.Now:dd/MM/yyyy}{Environment.NewLine}" +
                                 $"Product: {comboBox1.Text}{Environment.NewLine}" +
                                 $"Price/Piece: {piece:F2}{Environment.NewLine}" +
                                 $"Quantity: {quantity}{Environment.NewLine}" +
                                 $"Total Price: {totalPrice:F2}";
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            register f1 = new register();
            f1.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sq = new SqlConnection("Data Source=MAHMOUD;Initial Catalog=Supermarkets;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                SqlCommand cmd = new SqlCommand("Select Barcode, Name from items", sq);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Barcode";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

