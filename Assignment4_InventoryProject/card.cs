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
    public partial class card : UserControl
    {
        public card()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }
        private string prodname;

        public string Prodname
        {

            get { return prodname; }
            set { prodname = value; label1.Text = value; }
        }

        private string prodinventoryNumber;

        public string ProdinventoryNumber
        {

            get { return prodinventoryNumber; }
            set { prodinventoryNumber = value; label3.Text = value; }
        }


        private string prodprice;

        public string Prodprice
        {

            get { return prodprice; }
            set { prodprice = value; label2.Text = value; }
        }
    }
}
