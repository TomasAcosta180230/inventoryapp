using System.Data.SqlClient;
using System.Runtime.InteropServices;

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
            
                // Aquí puede ejecutar comandos SQL y trabajar con los datos
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

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}