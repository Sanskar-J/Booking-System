namespace Booking_System
{
    partial class ViewBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookingsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.but1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.but2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingsDGV)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(176, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Booking";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // BookingsDGV
            // 
            this.BookingsDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.BookingsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.BookingsDGV.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.BookingsDGV.ColumnHeadersHeight = 28;
            this.BookingsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingsDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.BookingsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingsDGV.Location = new System.Drawing.Point(39, 125);
            this.BookingsDGV.Name = "BookingsDGV";
            this.BookingsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.BookingsDGV.RowHeadersVisible = false;
            this.BookingsDGV.RowHeadersWidth = 47;
            this.BookingsDGV.Size = new System.Drawing.Size(886, 421);
            this.BookingsDGV.TabIndex = 2;
            this.BookingsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookingsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookingsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookingsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookingsDGV.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.BookingsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.BookingsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookingsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookingsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookingsDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.BookingsDGV.ThemeStyle.ReadOnly = false;
            this.BookingsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.BookingsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingsDGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Booking List";
            this.label3.UseCompatibleTextRendering = true;
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
            this.but1.ButtonText = "Back";
            this.but1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.Color.Black;
            this.but1.IdleBorderThickness = 1;
            this.but1.IdleCornerRadius = 20;
            this.but1.IdleFillColor = System.Drawing.Color.Transparent;
            this.but1.IdleForecolor = System.Drawing.Color.Black;
            this.but1.IdleLineColor = System.Drawing.Color.Black;
            this.but1.Location = new System.Drawing.Point(288, 575);
            this.but1.Margin = new System.Windows.Forms.Padding(5);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(181, 41);
            this.but1.TabIndex = 18;
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
            this.but2.ButtonText = "Delete Booking";
            this.but2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ForeColor = System.Drawing.Color.Black;
            this.but2.IdleBorderThickness = 1;
            this.but2.IdleCornerRadius = 20;
            this.but2.IdleFillColor = System.Drawing.Color.Transparent;
            this.but2.IdleForecolor = System.Drawing.Color.Black;
            this.but2.IdleLineColor = System.Drawing.Color.Black;
            this.but2.Location = new System.Drawing.Point(479, 575);
            this.but2.Margin = new System.Windows.Forms.Padding(5);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(181, 41);
            this.but2.TabIndex = 17;
            this.but2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but2.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // ViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.BookingsDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooking";
            this.Load += new System.EventHandler(this.ViewBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView BookingsDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 but1;
        private Bunifu.Framework.UI.BunifuThinButton2 but2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
    }
}