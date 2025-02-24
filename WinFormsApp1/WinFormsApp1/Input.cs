using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.Data.SqlClient;



namespace WinFormsApp1
{
    public partial class Input : Form
    {
        string connectionString = ("Data Source=DESKTOP-1A9RN81;Initial Catalog=super_market;Integrated Security=True;Trust Server Certificate=True");

        public Input()
        {
            InitializeComponent();
            fillComboBox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=MAHMOUD;Initial Catalog=Supermarkets;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            sq.Open();
            string insertqueryitems = "INSERT INTO items(Name, price, quantity, Oid, Sid) VALUES ( @Name, @price, @quantity, @Oid, @Sid)";
            string AddSupplier = "INSERT INTO supplier VALUES ( @Name)";
            string AddSupplierPhone = "INSERT INTO supplier_phone VALUES (@phone, @Sid)";
            SqlCommand cmd = new SqlCommand(insertqueryitems, sq);
            SqlCommand sup = new SqlCommand(AddSupplier, sq);
            SqlCommand pho = new SqlCommand(AddSupplierPhone, sq);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@price", textBox2.Text);
            cmd.Parameters.AddWithValue("@quantity", textBox3.Text);
            cmd.Parameters.AddWithValue("@Oid", "1");
            cmd.Parameters.AddWithValue("@Sid", "1");
      
            sup.Parameters.AddWithValue("@Name", comboBox1.Text);

            pho.Parameters.AddWithValue("@Sid", "2");
            pho.Parameters.AddWithValue("@phone", comboBox2.Text);
            cmd.ExecuteNonQuery();
            sup.ExecuteNonQuery();
            pho.ExecuteNonQuery();
            MessageBox.Show("Product Has Been Added Succesfully", "info", MessageBoxButtons.OK);
            sq.Close();


        }
        public void fillComboBox()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
