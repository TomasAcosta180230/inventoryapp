namespace inventoryapp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TITTLE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressMenu = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TITTLE);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 172);
            this.panel1.TabIndex = 0;
            // 
            // TITTLE
            // 
            this.TITTLE.AutoSize = true;
            this.TITTLE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TITTLE.Location = new System.Drawing.Point(197, 55);
            this.TITTLE.Name = "TITTLE";
            this.TITTLE.Size = new System.Drawing.Size(724, 77);
            this.TITTLE.TabIndex = 1;
            this.TITTLE.Text = "SYSTEM INVENTORY";
            this.TITTLE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventoryapp.Properties.Resources.inventory_management_blog;
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.PassInput);
            this.panel2.Controls.Add(this.UserInput);
            this.panel2.Controls.Add(this.User);
            this.panel2.Location = new System.Drawing.Point(14, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 367);
            this.panel2.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(402, 160);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(129, 27);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(421, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(322, 199);
            this.PassInput.Name = "PassInput";
            this.PassInput.PlaceholderText = "Enter Password";
            this.PassInput.Size = new System.Drawing.Size(297, 27);
            this.PassInput.TabIndex = 3;
            this.PassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserInput
            // 
            this.UserInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UserInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.UserInput.Location = new System.Drawing.Point(317, 97);
            this.UserInput.Name = "UserInput";
            this.UserInput.PlaceholderText = "Enter the Username";
            this.UserInput.Size = new System.Drawing.Size(302, 27);
            this.UserInput.TabIndex = 2;
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(430, 55);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(72, 27);
            this.User.TabIndex = 0;
            this.User.Text = "User:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressMenu);
            this.panel3.Location = new System.Drawing.Point(16, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 137);
            this.panel3.TabIndex = 2;
            // 
            // progressMenu
            // 
            this.progressMenu.Location = new System.Drawing.Point(140, 43);
            this.progressMenu.Name = "progressMenu";
            this.progressMenu.Size = new System.Drawing.Size(702, 62);
            this.progressMenu.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label TITTLE;
        private Button button1;
        private TextBox PassInput;
        private TextBox UserInput;
        private Label User;
        private ProgressBar progressMenu;
        private Label Password;
    }
}