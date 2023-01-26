using inventoryapp.Functions;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static inventoryapp.Functions.db;
using static inventoryapp.Functions.USER;

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
            
            string USERNAME = UserInput.Text;
            string PASS = PassInput.Text;

            var db = Conns();
            var res = logiUser(USERNAME,PASS,db);
            if(res == "1")
            {
                Dashboardcs dashboardcs = new Dashboardcs();
                this.Enabled = false;
                this.Hide();
                dashboardcs.LoginName.Text = USERNAME;
                dashboardcs.Show();
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