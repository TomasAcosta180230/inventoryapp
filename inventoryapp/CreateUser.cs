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

        private void RoleComboBox_Paint(object sender, PaintEventArgs e)
        {
            
            // Obtener el texto de placeholder
            string placeholder = "Seleccione una opción";

            // Comprobar si el ComboBox está vacío
            if (RoleComboBox.SelectedIndex == -1 && RoleComboBox.Text == "")
            {
                // Obtener la posición del placeholder
                PointF location = new PointF(2, (RoleComboBox.Height - e.Graphics.MeasureString(placeholder, RoleComboBox.Font).Height) / 2);

                // Centrar el placeholder en la posición
                using (SolidBrush brush = new SolidBrush(Color.Gray))
                {
                    e.Graphics.DrawString(placeholder, RoleComboBox.Font, brush, location);
                }
            }
        }


        Dashboardcs dashboardcs;
        private void CreateUser_Load(object sender, EventArgs e)
        {
            
            dashboardcs = (Dashboardcs)Application.OpenForms["Dashboardcs"];
            
        }
        private void CreateUser_FormClosing(object sender, EventArgs e)
        {
            dashboardcs.Enabled = true;

        }
    }
}
