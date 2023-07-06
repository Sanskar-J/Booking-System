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
        public Admin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (AdminTb.Text == "")
                MessageBox.Show("Please Enter Credentials");
            else if (AdminTb.Text.Equals("password"))
            {
                Staff st = new Staff();
                st.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect Admin Credentials");
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
