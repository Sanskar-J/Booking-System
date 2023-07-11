namespace Booking_System
{
    partial class Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffNameTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StaffPhoneTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffPasswordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffGenderCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StaffDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.but5 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but4 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but6 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Bebas Neue", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(917, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 46);
            this.label12.TabIndex = 2;
            this.label12.Text = "X";
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
            this.label1.Size = new System.Drawing.Size(85, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff";
            // 
            // StaffNameTb
            // 
            this.StaffNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffNameTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameTb.Location = new System.Drawing.Point(102, 98);
            this.StaffNameTb.Name = "StaffNameTb";
            this.StaffNameTb.Size = new System.Drawing.Size(189, 33);
            this.StaffNameTb.TabIndex = 22;
            this.StaffNameTb.TextChanged += new System.EventHandler(this.StaffNameTb_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 34);
            this.label11.TabIndex = 21;
            this.label11.Text = "Name";
            // 
            // StaffPhoneTb
            // 
            this.StaffPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffPhoneTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPhoneTb.Location = new System.Drawing.Point(384, 98);
            this.StaffPhoneTb.Name = "StaffPhoneTb";
            this.StaffPhoneTb.Size = new System.Drawing.Size(189, 33);
            this.StaffPhoneTb.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Phone";
            // 
            // StaffPasswordTb
            // 
            this.StaffPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffPasswordTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPasswordTb.Location = new System.Drawing.Point(724, 98);
            this.StaffPasswordTb.Name = "StaffPasswordTb";
            this.StaffPasswordTb.Size = new System.Drawing.Size(189, 33);
            this.StaffPasswordTb.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // StaffGenderCb
            // 
            this.StaffGenderCb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffGenderCb.FormattingEnabled = true;
            this.StaffGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StaffGenderCb.Location = new System.Drawing.Point(113, 141);
            this.StaffGenderCb.Name = "StaffGenderCb";
            this.StaffGenderCb.Size = new System.Drawing.Size(121, 33);
            this.StaffGenderCb.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 34);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 34);
            this.label5.TabIndex = 36;
            this.label5.Text = "Booking List";
            // 
            // StaffDGV
            // 
            this.StaffDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.StaffDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffDGV.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffDGV.ColumnHeadersHeight = 28;
            this.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffDGV.Location = new System.Drawing.Point(68, 298);
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StaffDGV.RowHeadersVisible = false;
            this.StaffDGV.RowHeadersWidth = 47;
            this.StaffDGV.Size = new System.Drawing.Size(855, 286);
            this.StaffDGV.TabIndex = 35;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffDGV.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.StaffDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StaffDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.StaffDGV.ThemeStyle.ReadOnly = false;
            this.StaffDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffDGV.ThemeStyle.RowsStyle.Height = 22;
            this.StaffDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
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
            this.but5.ButtonText = "Admin Logout";
            this.but5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.ForeColor = System.Drawing.Color.Black;
            this.but5.IdleBorderThickness = 1;
            this.but5.IdleCornerRadius = 20;
            this.but5.IdleFillColor = System.Drawing.Color.Transparent;
            this.but5.IdleForecolor = System.Drawing.Color.Black;
            this.but5.IdleLineColor = System.Drawing.Color.Black;
            this.but5.Location = new System.Drawing.Point(294, 611);
            this.but5.Margin = new System.Windows.Forms.Padding(5);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(181, 41);
            this.but5.TabIndex = 34;
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
            this.but3.ButtonText = "Edit Staff";
            this.but3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.ForeColor = System.Drawing.Color.Black;
            this.but3.IdleBorderThickness = 1;
            this.but3.IdleCornerRadius = 20;
            this.but3.IdleFillColor = System.Drawing.Color.Transparent;
            this.but3.IdleForecolor = System.Drawing.Color.Black;
            this.but3.IdleLineColor = System.Drawing.Color.Black;
            this.but3.Location = new System.Drawing.Point(504, 188);
            this.but3.Margin = new System.Windows.Forms.Padding(5);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(181, 41);
            this.but3.TabIndex = 32;
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
            this.but4.Location = new System.Drawing.Point(695, 188);
            this.but4.Margin = new System.Windows.Forms.Padding(5);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(181, 41);
            this.but4.TabIndex = 31;
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
            this.but1.ButtonText = "Add Staff";
            this.but1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.Color.Black;
            this.but1.IdleBorderThickness = 1;
            this.but1.IdleCornerRadius = 20;
            this.but1.IdleFillColor = System.Drawing.Color.Transparent;
            this.but1.IdleForecolor = System.Drawing.Color.Black;
            this.but1.IdleLineColor = System.Drawing.Color.Black;
            this.but1.Location = new System.Drawing.Point(122, 188);
            this.but1.Margin = new System.Windows.Forms.Padding(5);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(181, 41);
            this.but1.TabIndex = 30;
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
            this.but2.ButtonText = "Delete Staff";
            this.but2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ForeColor = System.Drawing.Color.Black;
            this.but2.IdleBorderThickness = 1;
            this.but2.IdleCornerRadius = 20;
            this.but2.IdleFillColor = System.Drawing.Color.Transparent;
            this.but2.IdleForecolor = System.Drawing.Color.Black;
            this.but2.IdleLineColor = System.Drawing.Color.Black;
            this.but2.Location = new System.Drawing.Point(313, 188);
            this.but2.Margin = new System.Windows.Forms.Padding(5);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(181, 41);
            this.but2.TabIndex = 29;
            this.but2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but2.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // but6
            // 
            this.but6.ActiveBorderThickness = 1;
            this.but6.ActiveCornerRadius = 20;
            this.but6.ActiveFillColor = System.Drawing.Color.Black;
            this.but6.ActiveForecolor = System.Drawing.Color.Transparent;
            this.but6.ActiveLineColor = System.Drawing.Color.DimGray;
            this.but6.BackColor = System.Drawing.SystemColors.Control;
            this.but6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but6.BackgroundImage")));
            this.but6.ButtonText = "Home";
            this.but6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.ForeColor = System.Drawing.Color.Black;
            this.but6.IdleBorderThickness = 1;
            this.but6.IdleCornerRadius = 20;
            this.but6.IdleFillColor = System.Drawing.Color.Transparent;
            this.but6.IdleForecolor = System.Drawing.Color.Black;
            this.but6.IdleLineColor = System.Drawing.Color.Black;
            this.but6.Location = new System.Drawing.Point(485, 611);
            this.but6.Margin = new System.Windows.Forms.Padding(5);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(181, 41);
            this.but6.TabIndex = 37;
            this.but6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but6.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 676);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StaffDGV);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.StaffGenderCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffPasswordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StaffPhoneTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffNameTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StaffNameTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox StaffPhoneTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StaffPasswordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StaffGenderCb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 but1;
        private Bunifu.Framework.UI.BunifuThinButton2 but2;
        private Bunifu.Framework.UI.BunifuThinButton2 but3;
        private Bunifu.Framework.UI.BunifuThinButton2 but4;
        private Bunifu.Framework.UI.BunifuThinButton2 but5;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView StaffDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 but6;
    }
}