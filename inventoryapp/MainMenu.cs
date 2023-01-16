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
            this.OnMouseHover()
        }
    }
}