using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment4_InventoryProject
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 disposer = new Form1();
            disposer.Show();
            this.Hide();
        }

        private void displayAllRegisteredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAll displayAll = new DisplayAll();
            displayAll.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//search
        {
            Regex reg = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (string.IsNullOrEmpty(Searchtxt.Text))
            {
                MessageBox.Show("Search field can't be empty", "Error");
            }
            else
            {
                if (!(reg.IsMatch(Searchtxt.Text)))
                {
                    errorProvider1.SetError(Searchtxt, "Incorrect format (No Symbols or numbers " +
                        "and First letter must be capital)");
                }
                else
                {
                   // var item = Inventory.findOne(Searchtxt.Text);
                    var item = Inventory.findAll(Searchtxt.Text);
                    if (item.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("No item is found!");                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        //dataGridView1.DataSource = Inventory.findOne(Searchtxt.Text);
                        dataGridView1.DataSource = Inventory.findAll(Searchtxt.Text);
                        //dataGridView1.DataSource=item;
                    }
                }
            }
        }
    }
}
    

