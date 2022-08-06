using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_InventoryProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Teddy" && textBox2.Text == "adimn")
            { MessageBox.Show("Login Successful!");
                Form1 bas = new Form1(textBox1.Text);
                bas.Show();
                this.Hide();
            }
            else { MessageBox.Show("Login unsuccessful!"); }
        }
    }
}
