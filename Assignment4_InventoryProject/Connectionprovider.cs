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
//update save (on db)and getallproducts(get data from table)

namespace Assignment4_InventoryProject
{
    public partial class Connectionprovider : Form
    {
        Inventory inventory = new Inventory();

        public Connectionprovider()//constructor to fetch
        {
            List<Inventory> list = new List<Inventory>();
            try
            {
                String Query, Query2, query3 = "";


                String path = @"Data Source=.;Initial Catalog= inventory; Integrated Security =True;";

                using (SqlConnection conn = new SqlConnection(path))//conn.close is done automatically
                {

                    conn.Open();

                    MessageBox.Show("connected");

                    //data store


                    Query2 = "select * from inventory";
                   // Query = "insert into inventory  values (inventory.Number,inventory.price,'inventory.objectname',inventory.count,inventory.inventoryNumber) ";
                    //SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlCommand cmd2 = new SqlCommand(Query2, conn);

                  //  SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                   // adapter.InsertCommand.ExecuteNonQuery();
                    SqlDataReader result = cmd2.ExecuteReader();//Returns only affected rows
                 //   list.Add();--how to add the selected data to list                                        // >>   >>  >>  >>  >>>.EexcuteScalar();//Returns only a single value//
                                                                //both of the above can be accesed directly without a loop
                                                                //but ExecuteReader returns a result set
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }


        public Connectionprovider(Inventory inventory)//constructor to add(save)

        {
            try
            {
                String Query, Query2, query3 = "";


                String path = @"Data Source=.;Initial Catalog= inventory; Integrated Security =True;";

                using (SqlConnection conn = new SqlConnection(path))//conn.close is done automatically
                {

                    conn.Open();

                    MessageBox.Show("connected");

                    //data store


                   // Query2 = "select * from inventory";
                    Query = "insert into inventory  values (inventory.Number,inventory.price,'inventory.objectname',inventory.count,inventory.inventoryNumber) ";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                  //  SqlCommand cmd2 = new SqlCommand(Query2, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.InsertCommand.ExecuteNonQuery();
                  //  SqlDataReader result = cmd2.ExecuteReader();//Returns only affected rows
                                                                // >>   >>  >>  >>  >>>.EexcuteScalar();//Returns only a single value//
                                                                //both of the above can be accesed directly without a loop
                                                                //but ExecuteReader returns a result set
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         /*   try
            {
                String path = @"Data Source=.;Initial Catalog= inventory; Integrated Security =True;";

                using (SqlConnection conn = new SqlConnection(path))//conn.close is done automatically
                {
                    conn.Open();
                    MessageBox.Show("connected");
                    //data store
                    String Query = "insert into inventory  values (2,90.90,'Pcgn',2,233) ";
                    SqlCommand cmd = new SqlCommand(Query,conn);
                      var result = cmd.ExecuteNonQuery();//Returns only affected rows
                    // >>   >>  >>  >>  >>>.EexcuteScalar();//Returns only a single value//
                    //both of the above can be accesed directly without a loop
                    //but ExecuteReader returns a result set
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            } **/

        }

        private void Connectionprovider_Load(object sender, EventArgs e)
        {
            try
            {
                String Query,Query2,query3 = "";


                String path = @"Data Source=.;Initial Catalog= inventory; Integrated Security =True;";

                using (SqlConnection conn = new SqlConnection(path))//conn.close is done automatically
                {

                    conn.Open();
                    
                        MessageBox.Show("connected");

                    //data store


                    Query2 = "select * from inventory";
                     Query = "insert into inventory  values (inventory.Number,inventory.price,'inventory.objectname',inventory.count,inventory.inventoryNumber) ";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlCommand cmd2 = new SqlCommand(Query2, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.InsertCommand.ExecuteNonQuery();
                   SqlDataReader result = cmd2.ExecuteReader();//Returns only affected rows
                                                       // >>   >>  >>  >>  >>>.EexcuteScalar();//Returns only a single value//
                                                       //both of the above can be accesed directly without a loop
                                                       //but ExecuteReader returns a result set
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
