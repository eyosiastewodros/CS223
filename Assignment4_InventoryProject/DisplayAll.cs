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
          

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Mainform mainform = new Mainform();
            mainform.Show();
            this.Close();
        }

        private void DisplayAll_Load(object sender, EventArgs e)
        {
            foreach (var item in Inventory.getAllProducts())
            {
                card p = new card();
                p.Prodname = item.objectName;
                p.Prodprice = item.price.ToString();
                p.ProdinventoryNumber = item.inventoryNumber.ToString();
                   p.Click += button1_Click;
                //also add detail page on photo
                // databse lemetekem we just gott a import
                //SEnd connection string When creating object
                //SqlConnection s=new SqlConnection(//in here we have a string that begins with an @ signs(whuch helps us ignore escape characters));

                //two types of authentication //windows and Sql(learn them)
                flowLayoutPanel1.Controls.Add(p);


            }
        }
    }
}
