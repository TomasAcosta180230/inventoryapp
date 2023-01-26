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
using static inventoryapp.Functions.USER;


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
            var db = Conns();
            var name = NameInput.Text;
            var lastname = LastNameInput.Text;
            var pass = PassInput.Text;
            var role = RoleComboBox.SelectedItem.ToString();
            var role_id = roleid(role, db);

            var res = createUser(name,lastname,pass, role_id, db);
            if (res != "0")
            {
                MessageBox.Show("Cuenta creada correctamente!", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se creo el usuario intente nuevamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
