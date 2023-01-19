using System.Data.SqlClient;

namespace inventoryapp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Cerra ventana
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Minimizar la ventana
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Server=appserver32.ddns.net;Database=master;Trusted_Connection=false;User Id=user12;Password=Alejandro12;";
            
                // Aqu� puede ejecutar comandos SQL y trabajar con los datos
                try
                {
                    connection.Open();
                    MessageBox.Show("Conected!", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                catch (SqlException es)
                {
                    MessageBox.Show(es.ToString(), "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
                }
                connection.Close();
            }
        }
    }
}