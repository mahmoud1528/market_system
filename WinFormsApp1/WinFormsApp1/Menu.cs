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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input f3 = new Input();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register f1 = new register();
            f1.ShowDialog(); 
            f1.Close();
        }
    }
}
