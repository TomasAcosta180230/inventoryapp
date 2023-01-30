namespace inventoryapp.Forms
{
    partial class Scan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.donelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScanInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.donelabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ScanInput);
            this.panel1.Location = new System.Drawing.Point(-9, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 264);
            this.panel1.TabIndex = 0;
            // 
            // donelabel
            // 
            this.donelabel.AutoSize = true;
            this.donelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donelabel.ForeColor = System.Drawing.Color.Lime;
            this.donelabel.Location = new System.Drawing.Point(260, 165);
            this.donelabel.Name = "donelabel";
            this.donelabel.Size = new System.Drawing.Size(42, 20);
            this.donelabel.TabIndex = 3;
            this.donelabel.Text = "label";
            this.donelabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 53);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(249, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "SCAN PRODUCTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(204, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // ScanInput
            // 
            this.ScanInput.Location = new System.Drawing.Point(254, 124);
            this.ScanInput.Name = "ScanInput";
            this.ScanInput.Size = new System.Drawing.Size(271, 27);
            this.ScanInput.TabIndex = 0;
            this.ScanInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanInput_KeyDown);
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 243);
            this.Controls.Add(this.panel1);
            this.Name = "Scan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox ScanInput;
        public Label donelabel;
    }
}