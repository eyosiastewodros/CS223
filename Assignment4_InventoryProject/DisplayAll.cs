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
    public partial class DisplayAll : Form
    {
        public DisplayAll()
        {
            InitializeComponent();
            dataGridDisplay.DataSource = null;
            dataGridDisplay.DataSource = Inventory.getAllProducts();
            dataGridDisplay.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Mainform mainform = new Mainform();
            mainform.Show();
            this.Close();
        }
    }
}
