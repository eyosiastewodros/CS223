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
        public Form1()
        {
           
            InitializeComponent();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            Inventory inventory = new Inventory();
            //  Regex renum = new Regex(@"^[0-9]{6}$");//max count,inventory num and num==10^6
            //  Regex reword = new Regex(@"^[a-z]$");
            //  Regex price = new Regex(@"^[0-9]{7}\.[0-9]{2}$");//maximum price is in millions
            Regex renum = new Regex(@"^\d+$"); 
            Regex reword = new Regex(@"^\w+(\s\w+){0,3}$"); 
            Regex price = new Regex(@"^\d+(\.\d{1,2})?$"); 
            Boolean[] check = new Boolean[] { false, false, false, false, false };


            if (String.IsNullOrEmpty(txtBox_count.Text))
            {

                errorProvider1.SetError(txtBox_count, "count is required!");
                check[0] = false;
            }
            else if (!renum.IsMatch(txtBox_count.Text))
            {
                check[0] = false;
                errorProvider1.SetError(txtBox_count, " you should enter a numeric value! ");
            }
            else
            {
                inventory.count = int.Parse(txtBox_count.Text);

                check[0] = true;
            }


            if (String.IsNullOrEmpty(txtBox_price.Text))
            {
                check[1] = false;
                errorProvider1.SetError(txtBox_price, "Price is required!");
            }
            else if (!price.IsMatch(txtBox_price.Text))
            {
                check[1] = false;
                errorProvider1.SetError(txtBox_price, " you should enter a numeric value in a decimal format(2 decimals)! ");
            }
            else
            {
                inventory.price = double.Parse(txtBox_price.Text);

                check[1] = true;
            }


            if (String.IsNullOrEmpty(txtBox_number.Text))
            {
                check[2] = false;
                errorProvider1.SetError(txtBox_number, "Number is required!");
            }
            else if (!renum.IsMatch(txtBox_number.Text))
            {
                check[2] = false;
                errorProvider1.SetError(txtBox_number, " you should enter a numeric value! ");
            }
            else
            {
                check[2] = true;
            }
            if (String.IsNullOrEmpty(txtBox_inventoryNumber.Text))
            {
                check[3] = false;
                errorProvider1.SetError(txtBox_inventoryNumber, "Inventory Number is required!");
            }
            else if (!renum.IsMatch(txtBox_inventoryNumber.Text))
            {
                check[3] = false;
                errorProvider1.SetError(txtBox_inventoryNumber, " you should enter a numeric value! ");
            }
            else
            {
                inventory.inventoryNumber = int.Parse(txtBox_inventoryNumber.Text);

                check[3] = true;
                
            }
            if (String.IsNullOrEmpty(txtBox_objectName.Text))
            {
                check[4] = false;

                errorProvider1.SetError(txtBox_objectName, "name is required!");
            }
            else if (!reword.IsMatch(txtBox_objectName.Text))
            {
                check[4] = false;
                errorProvider1.SetError(txtBox_objectName, " you should enter a non-special character! ");
            }
            else
            {
                inventory.objectName = txtBox_objectName.Text;

                check[4] = true;
            }

            if (check[0] == check[1] == check[2] == check[3]== check[4] == true)
            {
                inventory.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Inventory.getAllProducts();
                MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully", "Success");

            }


            inventory.date = dateTimePicker1.Value;
            
           

          


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
