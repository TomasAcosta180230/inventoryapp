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
            this.CreateBtnUser = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.TITTLE);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 136);
            this.panel1.TabIndex = 0;
            // 
            // TITTLE
            // 
            this.TITTLE.AutoSize = true;
            this.TITTLE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TITTLE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TITTLE.Location = new System.Drawing.Point(185, 23);
            this.TITTLE.Name = "TITTLE";
            this.TITTLE.Size = new System.Drawing.Size(724, 77);
            this.TITTLE.TabIndex = 1;
            this.TITTLE.Text = "SYSTEM INVENTORY";
            this.TITTLE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventoryapp.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(46, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.CreateBtnUser);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.PassInput);
            this.panel2.Controls.Add(this.UserInput);
            this.panel2.Controls.Add(this.User);
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 508);
            this.panel2.TabIndex = 1;
            // 
            // CreateBtnUser
            // 
            this.CreateBtnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.CreateBtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtnUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateBtnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateBtnUser.Location = new System.Drawing.Point(525, 311);
            this.CreateBtnUser.Name = "CreateBtnUser";
            this.CreateBtnUser.Size = new System.Drawing.Size(94, 29);
            this.CreateBtnUser.TabIndex = 6;
            this.CreateBtnUser.Text = "Create";
            this.CreateBtnUser.UseVisualStyleBackColor = true;
            this.CreateBtnUser.Click += new System.EventHandler(this.CreateBtnUser_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(446, 217);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(129, 27);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(405, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(366, 256);
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
            this.UserInput.Location = new System.Drawing.Point(361, 154);
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
            this.User.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User.Location = new System.Drawing.Point(474, 112);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(72, 27);
            this.User.TabIndex = 0;
            this.User.Text = "User:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(-3, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 37);
            this.panel3.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(985, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Inventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private Label Password;
        private Button CreateBtnUser;
    }
}