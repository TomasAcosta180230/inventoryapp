using inventoryapp.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static inventoryapp.Functions.db;
using static inventoryapp.Functions.Products;
using Timer = System.Windows.Forms.Timer;

namespace inventoryapp.Forms
{
    public partial class Scan : Form
    {
        public Scan()
        {
            InitializeComponent();
          
        }
     
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ScanInput_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                var db = Conns();
                var id = ScanInput.Text;
                var conccheck = checkifproductexist(db, id);
                if (conccheck == "1")
                {
                    //System.Threading.Thread.Sleep(2000);
                    var r = insertinsertnewqty(db, id);
                    if (r == "1") 
                    {
                        
                        
                        donelabel.Visible = true;
                        donelabel.Text = "Succesfuly";
                        donelabel.ForeColor = Color.Red;
                        Application.DoEvents();
                        donelabel.ForeColor = Color.Green;
                        ScanInput.Text = "";
                        MessageBoxTemporal.Show("Producto agregado", "Inventory", 1, false);
                        //timer1.Start();
                    }
                    
                    //donelabel.Visible = false;

                }

                var res = checkifitemisregister(db, id);
                
                if (conccheck == "0")
                {
                    MessageBox.Show("Producto no registrado! se tiene que registrar por primera vez, solo sucede una vez por cada producto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //insertnewproducts();
                }
            }
           

        }

        private void ScanInput_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
