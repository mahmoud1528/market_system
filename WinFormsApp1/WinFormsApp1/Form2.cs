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
    public partial class Form2 : Form
    {
        private string rtb1;
        public TextBox mytextbox
        {
            get { return textBox1; }
        }
        public Form2(string tb1)
        {
            InitializeComponent();
            rtb1 = tb1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                string product = comboBox1.Text;
                int Piece = int.Parse(textBox1.Text);
                int Quantity = int.Parse(textBox3.Text);
                DateTime dateTime = DateTime.Now;
                if (Piece == null)
                {
                    MessageBox.Show("Can not be null", "logic error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string message = "Name :" + rtb1 + Environment.NewLine + "Date : " + dateTime + Environment.NewLine + "Product : " + product + Environment.NewLine + "Price/Piece : " + Piece + Environment.NewLine + "Quantity " + Quantity + Environment.NewLine + "Total Price : " + (Piece * Quantity);
                    MessageBox.Show(message);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please select product", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
