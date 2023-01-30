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
namespace inventoryapp.Forms
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
          
                e.CellStyle.BackColor = Color.Black;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = Color.DarkGreen;
                e.CellStyle.SelectionForeColor = Color.White;
                 
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Scan s = new Scan();
            s.Show();
            this.Enabled = false;
           
            s.FormClosed += (s, args) => { this.Enabled = true; };
            this.Show();

        }
    }
}
