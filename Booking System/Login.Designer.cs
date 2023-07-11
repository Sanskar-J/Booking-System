namespace Booking_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminLogin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainLoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 283);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Booking_System.Properties.Resources.photograph;
            this.pictureBox2.Location = new System.Drawing.Point(83, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(388, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Photography Booking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // UsernameTb
            // 
            this.UsernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTb.Location = new System.Drawing.Point(390, 102);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(286, 33);
            this.UsernameTb.TabIndex = 2;
            // 
            // PassTb
            // 
            this.PassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTb.Location = new System.Drawing.Point(390, 145);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.Size = new System.Drawing.Size(286, 33);
            this.PassTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // AdminLogin
            // 
            this.AdminLogin.AutoSize = true;
            this.AdminLogin.BackColor = System.Drawing.Color.Black;
            this.AdminLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogin.ForeColor = System.Drawing.Color.White;
            this.AdminLogin.Location = new System.Drawing.Point(497, 244);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(57, 27);
            this.AdminLogin.TabIndex = 8;
            this.AdminLogin.Text = "ADMIN";
            this.AdminLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            this.AdminLogin.MouseLeave += new System.EventHandler(this.AdminLogin_MouseLeave);
            this.AdminLogin.MouseHover += new System.EventHandler(this.AdminLogin_MouseHover);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(694, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 53);
            this.label12.TabIndex = 9;
            this.label12.Text = "X";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.UseCompatibleTextRendering = true;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Booking_System.Properties.Resources.photo_camera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Booking_System.Properties.Resources.photo_camera;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mainLoginButton
            // 
            this.mainLoginButton.ActiveBorderThickness = 1;
            this.mainLoginButton.ActiveCornerRadius = 20;
            this.mainLoginButton.ActiveFillColor = System.Drawing.Color.Black;
            this.mainLoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.mainLoginButton.ActiveLineColor = System.Drawing.Color.DimGray;
            this.mainLoginButton.BackColor = System.Drawing.Color.White;
            this.mainLoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainLoginButton.BackgroundImage")));
            this.mainLoginButton.ButtonText = "LOGIN";
            this.mainLoginButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mainLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLoginButton.ForeColor = System.Drawing.Color.Black;
            this.mainLoginButton.IdleBorderThickness = 1;
            this.mainLoginButton.IdleCornerRadius = 20;
            this.mainLoginButton.IdleFillColor = System.Drawing.Color.White;
            this.mainLoginButton.IdleForecolor = System.Drawing.Color.Black;
            this.mainLoginButton.IdleLineColor = System.Drawing.Color.Black;
            this.mainLoginButton.Location = new System.Drawing.Point(438, 186);
            this.mainLoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.mainLoginButton.Name = "mainLoginButton";
            this.mainLoginButton.Size = new System.Drawing.Size(181, 41);
            this.mainLoginButton.TabIndex = 6;
            this.mainLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLoginButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMe.Location = new System.Drawing.Point(610, 235);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(111, 25);
            this.RememberMe.TabIndex = 10;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 283);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainLoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.TextBox PassTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 mainLoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label AdminLogin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox RememberMe;
    }
}

