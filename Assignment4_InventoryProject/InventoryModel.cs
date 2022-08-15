using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_InventoryProject
{
  public  class Inventory
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public int inventoryNumber { get; set; }
        public String objectName { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public String originOfProduct { get; set; }

        public String productState { get; set; }
        public Boolean onsale { get; set; }
        public Boolean  delivery{ get; set; }
    public Boolean availabilty { get; set; }
        
//   Form1 form1=new Form1();
static public List<Inventory> listofproducts = new List<Inventory>();
        string r;

        public void save(){

            listofproducts.Add(this); 
           
        }
        static public List<Inventory> getAllProducts() {
            return listofproducts;
        }

       // public static List<Inventory> findOne(string name);

        public static List<Inventory> findAll(string name)
        {
            return listofproducts.FindAll(p => p.objectName == name);
        }



    }
}
//InventoryModel inv=new InventoryModel{};
