using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System
{
    public partial class Admin : Form
    {
        string name;
        public Admin(string name)
        {
            InitializeComponent();
            label1.Font= new Font(Program.pfc2.Families[0], label1.Font.Size);
            label2.Font= new Font(Program.pfc.Families[1], label2.Font.Size);
            label12.Font= new Font(Program.pfc2.Families[0], label12.Font.Size);
            AdminTb.Font= new Font(Program.pfc.Families[1], AdminTb.Font.Size);
            logButton.Font= new Font(Program.pfc.Families[1], logButton.Font.Size);
            AdminLogin.Font= new Font(Program.pfc.Families[1], AdminLogin.Font.Size);
            this.name = name;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (AdminTb.Text == "")
                MessageBox.Show("Please Enter Credentials");
            else if (AdminTb.Text.Equals("password"))
            {
                Staff st = new Staff("Admin");
                st.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect Admin Credentials");
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login(name);
            log.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLogin_MouseHover(object sender, EventArgs e)
        {
            AdminLogin.BackColor = Color.White;
            AdminLogin.ForeColor = Color.Black;
        }

        private void AdminLogin_MouseLeave(object sender, EventArgs e)
        {
            AdminLogin.BackColor = Color.Black;
            AdminLogin.ForeColor = Color.White;
        }
    }
}
