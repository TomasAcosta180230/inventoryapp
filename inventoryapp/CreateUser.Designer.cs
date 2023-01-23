namespace inventoryapp
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.CreateBtn);
            this.panel2.Controls.Add(this.RoleComboBox);
            this.panel2.Controls.Add(this.PassInput);
            this.panel2.Controls.Add(this.LastNameInput);
            this.panel2.Controls.Add(this.NameInput);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.User);
            this.panel2.Location = new System.Drawing.Point(-94, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 549);
            this.panel2.TabIndex = 5;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateBtn.Location = new System.Drawing.Point(545, 424);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(94, 29);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create User";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(436, 367);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(302, 28);
            this.RoleComboBox.TabIndex = 10;
            // 
            // PassInput
            // 
            this.PassInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PassInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.PassInput.Location = new System.Drawing.Point(436, 283);
            this.PassInput.Name = "PassInput";
            this.PassInput.PlaceholderText = "Enter the Password";
            this.PassInput.Size = new System.Drawing.Size(302, 27);
            this.PassInput.TabIndex = 9;
            this.PassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastNameInput
            // 
            this.LastNameInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LastNameInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.LastNameInput.Location = new System.Drawing.Point(436, 194);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.PlaceholderText = "Enter the Lastname";
            this.LastNameInput.Size = new System.Drawing.Size(302, 27);
            this.LastNameInput.TabIndex = 8;
            this.LastNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameInput
            // 
            this.NameInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.NameInput.Location = new System.Drawing.Point(436, 108);
            this.NameInput.Name = "NameInput";
            this.NameInput.PlaceholderText = "Enter the Name";
            this.NameInput.Size = new System.Drawing.Size(302, 27);
            this.NameInput.TabIndex = 7;
            this.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(546, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(506, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(529, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User.Location = new System.Drawing.Point(531, 61);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(108, 27);
            this.User.TabIndex = 3;
            this.User.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(248, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREATE USER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 116);
            this.panel1.TabIndex = 12;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label User;
        private ComboBox RoleComboBox;
        private TextBox PassInput;
        private TextBox LastNameInput;
        private TextBox NameInput;
        private Button CreateBtn;
        private Panel panel1;
    }
}