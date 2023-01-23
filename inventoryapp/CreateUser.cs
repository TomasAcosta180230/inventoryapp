using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryapp
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }

        internal void Cbodato(string cbo1)
        {
                RoleComboBox.Items.Add(cbo1);
        }
    }
}
