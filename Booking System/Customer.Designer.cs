namespace Booking_System
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustAddTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustPhoneTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.but5 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but4 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 70);
            this.panel1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Bebas Neue", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(920, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 56);
            this.label12.TabIndex = 2;
            this.label12.Text = "X";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.UseCompatibleTextRendering = true;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 35);
            this.label5.TabIndex = 49;
            this.label5.Text = "Customers List";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // CustAddTb
            // 
            this.CustAddTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustAddTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddTb.Location = new System.Drawing.Point(722, 95);
            this.CustAddTb.Name = "CustAddTb";
            this.CustAddTb.Size = new System.Drawing.Size(189, 33);
            this.CustAddTb.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 35);
            this.label3.TabIndex = 41;
            this.label3.Text = "Address";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // CustPhoneTb
            // 
            this.CustPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustPhoneTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPhoneTb.Location = new System.Drawing.Point(395, 95);
            this.CustPhoneTb.Name = "CustPhoneTb";
            this.CustPhoneTb.Size = new System.Drawing.Size(189, 33);
            this.CustPhoneTb.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 35);
            this.label2.TabIndex = 39;
            this.label2.Text = "Phone";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // CustNameTb
            // 
            this.CustNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustNameTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(117, 95);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(189, 33);
            this.CustNameTb.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 35);
            this.label11.TabIndex = 37;
            this.label11.Text = "Name";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.CustomerDGV.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomerDGV.ColumnHeadersHeight = 28;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.CustomerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.Location = new System.Drawing.Point(56, 268);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.CustomerDGV.RowHeadersVisible = false;
            this.CustomerDGV.RowHeadersWidth = 47;
            this.CustomerDGV.Size = new System.Drawing.Size(855, 286);
            this.CustomerDGV.TabIndex = 50;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.CustomerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Silver;
            this.CustomerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.CustomerDGV.ThemeStyle.ReadOnly = false;
            this.CustomerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.CustomerDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.CustomerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellContentClick);
            // 
            // but5
            // 
            this.but5.ActiveBorderThickness = 1;
            this.but5.ActiveCornerRadius = 20;
            this.but5.ActiveFillColor = System.Drawing.Color.Black;
            this.but5.ActiveForecolor = System.Drawing.Color.Transparent;
            this.but5.ActiveLineColor = System.Drawing.Color.DimGray;
            this.but5.BackColor = System.Drawing.SystemColors.Control;
            this.but5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but5.BackgroundImage")));
            this.but5.ButtonText = "Back";
            this.but5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.ForeColor = System.Drawing.Color.Black;
            this.but5.IdleBorderThickness = 1;
            this.but5.IdleCornerRadius = 20;
            this.but5.IdleFillColor = System.Drawing.Color.Transparent;
            this.but5.IdleForecolor = System.Drawing.Color.Black;
            this.but5.IdleLineColor = System.Drawing.Color.Black;
            this.but5.Location = new System.Drawing.Point(395, 597);
            this.but5.Margin = new System.Windows.Forms.Padding(5);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(181, 41);
            this.but5.TabIndex = 51;
            this.but5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but5.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // but3
            // 
            this.but3.ActiveBorderThickness = 1;
            this.but3.ActiveCornerRadius = 20;
            this.but3.ActiveFillColor = System.Drawing.Color.Black;
            this.but3.ActiveForecolor = System.Drawing.Color.Transparent;
            this.but3.ActiveLineColor = System.Drawing.Color.DimGray;
            this.but3.BackColor = System.Drawing.SystemColors.Control;
            this.but3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but3.BackgroundImage")));
            this.but3.ButtonText = "Edit Customer";
            this.but3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.ForeColor = System.Drawing.Color.Black;
            this.but3.IdleBorderThickness = 1;
            this.but3.IdleCornerRadius = 20;
            this.but3.IdleFillColor = System.Drawing.Color.Transparent;
            this.but3.IdleForecolor = System.Drawing.Color.Black;
            this.but3.IdleLineColor = System.Drawing.Color.Black;
            this.but3.Location = new System.Drawing.Point(499, 161);
            this.but3.Margin = new System.Windows.Forms.Padding(5);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(181, 41);
            this.but3.TabIndex = 48;
            this.but3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but3.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // but4
            // 
            this.but4.ActiveBorderThickness = 1;
            this.but4.ActiveCornerRadius = 20;
            this.but4.ActiveFillColor = System.Drawing.Color.Black;
            this.but4.ActiveForecolor = System.Drawing.Color.Transparent;
            this.but4.ActiveLineColor = System.Drawing.Color.DimGray;
            this.but4.BackColor = System.Drawing.SystemColors.Control;
            this.but4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but4.BackgroundImage")));
            this.but4.ButtonText = "Reset";
            this.but4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.ForeColor = System.Drawing.Color.Black;
            this.but4.IdleBorderThickness = 1;
            this.but4.IdleCornerRadius = 20;
            this.but4.IdleFillColor = System.Drawing.Color.Transparent;
            this.but4.IdleForecolor = System.Drawing.Color.Black;
            this.but4.IdleLineColor = System.Drawing.Color.Black;
            this.but4.Location = new System.Drawing.Point(690, 161);
            this.but4.Margin = new System.Windows.Forms.Padding(5);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(181, 41);
            this.but4.TabIndex = 47;
            this.but4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but4.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // but1
            // 
            this.but1.ActiveBorderThickness = 1;
            this.but1.ActiveCornerRadius = 20;
            this.but1.ActiveFillColor = System.Drawing.Color.Black;
            this.but1.ActiveForecolor = System.Drawing.Color.Transparent;
            this.but1.ActiveLineColor = System.Drawing.Color.DimGray;
            this.but1.BackColor = System.Drawing.SystemColors.Control;
            this.but1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but1.BackgroundImage")));
            this.but1.ButtonText = "Add Customer";
            this.but1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.Color.Black;
            this.but1.IdleBorderThickness = 1;
            this.but1.IdleCornerRadius = 20;
            this.but1.IdleFillColor = System.Drawing.Color.Transparent;
            this.but1.IdleForecolor = System.Drawing.Color.Black;
            this.but1.IdleLineColor = System.Drawing.Color.Black;
            this.but1.Location = new System.Drawing.Point(117, 161);
            this.but1.Margin = new System.Windows.Forms.Padding(5);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(181, 41);
            this.but1.TabIndex = 46;
            this.but1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but1.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // but2
            // 
            this.but2.ActiveBorderThickness = 1;
            this.but2.ActiveCornerRadius = 20;
            this.but2.ActiveFillColor = System.Drawing.Color.Black;
            this.but2.ActiveForecolor = System.Drawing.Color.Transparent;
            this.but2.ActiveLineColor = System.Drawing.Color.DimGray;
            this.but2.BackColor = System.Drawing.SystemColors.Control;
            this.but2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but2.BackgroundImage")));
            this.but2.ButtonText = "Delete Customer";
            this.but2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ForeColor = System.Drawing.Color.Black;
            this.but2.IdleBorderThickness = 1;
            this.but2.IdleCornerRadius = 20;
            this.but2.IdleFillColor = System.Drawing.Color.Transparent;
            this.but2.IdleForecolor = System.Drawing.Color.Black;
            this.but2.IdleLineColor = System.Drawing.Color.Black;
            this.but2.Location = new System.Drawing.Point(308, 161);
            this.but2.Margin = new System.Windows.Forms.Padding(5);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(181, 41);
            this.but2.TabIndex = 45;
            this.but2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but2.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 676);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.CustAddTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustPhoneTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 but3;
        private Bunifu.Framework.UI.BunifuThinButton2 but4;
        private Bunifu.Framework.UI.BunifuThinButton2 but1;
        private Bunifu.Framework.UI.BunifuThinButton2 but2;
        private System.Windows.Forms.TextBox CustAddTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustPhoneTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 but5;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
    }
}