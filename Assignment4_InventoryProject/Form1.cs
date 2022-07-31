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
    public partial class Form1 : Form
    {
        Form Back;
        public Form1()
        {
           
            InitializeComponent();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            Inventory inventory = new Inventory();
            Regex renum = new Regex(@"^\d+$");
            Regex reword = new Regex(@"^\w$");
            Regex price = new Regex(@"^\d+\.\d{2}$");
            Boolean[] check = new Boolean[] { false, false, true, true, false };


            if (String.IsNullOrEmpty(txtBox_count.Text) || txtBox_count.Text=="")
            {

                errorProvider1.SetError(txtBox_count, "count is required!");
            }
            else if (!renum.IsMatch(txtBox_count.Text))
            {
               
                errorProvider1.SetError(txtBox_count, " you should enter a numeric value! ");
            }
            else
            { // inventory.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Inventory.getAllProducts();
               
               // MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully", "Success");
               
            }


            if (String.IsNullOrEmpty(txtBox_price.Text))
            {

                errorProvider1.SetError(txtBox_price, "Number is required!");
            }
            else if (!price.IsMatch(txtBox_price.Text))
            {
                errorProvider1.SetError(txtBox_price, " you should enter a numeric value in a decimal format! ");
            }
            else
            { //inventory.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Inventory.getAllProducts();
               
               // MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully", "Success");
               
            }


            if (String.IsNullOrEmpty(txtBox_number.Text))
            {

                errorProvider1.SetError(txtBox_number, "Number is required!");
            }
            else if (!renum.IsMatch(txtBox_number.Text))
            {
                errorProvider1.SetError(txtBox_number, " you should enter a numeric value! ");
            }
            else
            {// inventory.save();
                dataGridView1.DataSource = null;            
                 dataGridView1.DataSource = Inventory.getAllProducts();
                
               // MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully","Success");
                
            }
            if (String.IsNullOrEmpty(txtBox_inventoryNumber.Text))
            {

                errorProvider1.SetError(txtBox_inventoryNumber, "Number is required!");
            }
            else if (!renum.IsMatch(txtBox_inventoryNumber.Text))
            {
                errorProvider1.SetError(txtBox_inventoryNumber, " you should enter a numeric value! ");
            }
            else
            {// inventory.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Inventory.getAllProducts();
               
              //  MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully", "Success");
                
            }
            if (String.IsNullOrEmpty(txtBox_objectName.Text)|| txtBox_objectName.Text ==" ")
            {

                errorProvider1.SetError(txtBox_objectName, "name is required!");
            }
            else if (!reword.IsMatch(txtBox_number.Text))
            {
                errorProvider1.SetError(txtBox_number, " you should enter a non-numeric value! ");
            }
            else
            {// inventory.save();
                dataGridView1.DataSource = null;
             //   dataGridView1.DataSource = Inventory.getAllProducts();
               
               // MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully", "Success");

            }

           // if (check[0] == check[1] == check[2] == check[3]== check[4] == true) ---unsuccesful


            inventory.date = dateTimePicker1.Value;
            inventory.inventoryNumber = int.Parse(txtBox_inventoryNumber.Text);
            inventory.objectName = txtBox_objectName.Text;
            inventory.count = int.Parse(txtBox_count.Text);
            inventory.price = double.Parse(txtBox_price.Text);
            inventory.save();
            dataGridView1.DataSource = Inventory.getAllProducts();
            MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully", "Success");


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
