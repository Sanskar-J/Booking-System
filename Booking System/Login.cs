using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Booking_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            Admin admin=new Admin();
            admin.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(UsernameTb.Text=="" || PassTb.Text=="")
                MessageBox.Show("Please Enter Credentials");
            else
            {
                try
                {
                    Con.Open();
                    string query = $"select count(*) from StaffTable where StaffName='{UsernameTb.Text}' and StaffPassword='{PassTb.Text}' ";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    if (dt.Rows[0][0].ToString().Equals("1"))
                    {
                        MainForm home = new MainForm();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials");
                        UsernameTb.Text = "";
                        PassTb.Text = "";
                    }

                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
