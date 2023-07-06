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
using System.IdentityModel.Protocols.WSTrust;

namespace Booking_System
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffNameTb.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            StaffPhoneTb.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            StaffGenderCb.Text = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            StaffPasswordTb.Text = StaffDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (StaffPhoneTb.Text == "")
            {
                staffKey = 0;
            }
            else
            {
                staffKey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPasswordTb.Text == "" || StaffGenderCb.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"insert into StaffTable values('{StaffNameTb.Text}','{StaffPhoneTb.Text}','{StaffGenderCb.SelectedItem.ToString()}','{StaffPasswordTb.Text}')";
                    SqlCommand sqlCommand = new SqlCommand(query, Con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Added");
                    
                    Con.Close();
                    populate();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // show data in table
        private void populate()
        {
            Con.Open();
            string query = "select * from StaffTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            var ds = new DataSet();
            adapter.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        // clear all fields
        int staffKey = 0;
        private void clear()
        {
            //custkey = 0;
            StaffNameTb.Text = "";
            StaffPhoneTb.Text = "";
            StaffPasswordTb.Text = "";
            StaffGenderCb.SelectedIndex = -1;
            staffKey = 0;

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            clear();
        }
        // delete button
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (staffKey == 0)
            {
                MessageBox.Show("Select the Staff to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"delete from StaffTable where StaffId={staffKey};";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Successfully");
                    Con.Close();
                    populate();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //update and edit
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPasswordTb.Text == ""||StaffGenderCb.SelectedIndex==-1 )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"update StaffTable set StaffName='{StaffNameTb.Text}',StaffPhone='{StaffPhoneTb.Text}',StaffPassword='{StaffPasswordTb.Text}',StaffGender='{StaffGenderCb.SelectedItem.ToString()}' where StaffId={staffKey};";
                    SqlCommand sqlCommand = new SqlCommand(query, Con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");

                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Admin admin=new Admin();
            admin.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
