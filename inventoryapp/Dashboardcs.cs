using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static inventoryapp.Functions.db;
using static inventoryapp.Functions.USER;
using System.Data.SqlClient;

namespace inventoryapp
{
    public partial class Dashboardcs : Form
    {
        public Dashboardcs()
        {
            InitializeComponent();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            
            this.Enabled = false;
            createUser.Show();
            var db = Conns();
            var comand = commandRole(db);

            SqlDataReader reader = comand.ExecuteReader();
            var a = "";

            while (reader.Read())
            {
                a = (reader["Role_Name"].ToString());
                createUser.Cbodato(a);
            }
        }



        MainMenu menu = new MainMenu();
      
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            menu.FormClosed += (s, args) => { this.Close(); };
            menu.Show();
            MessageBox.Show("Sesion Cerrada correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
        }

        
    }
}
