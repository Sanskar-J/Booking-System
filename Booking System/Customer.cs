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

namespace Booking_System
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        //exit button
        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // sql connector
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");
        // add customer button
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if(CustNameTb.Text=="" || CustAddTb.Text=="" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"insert into CustomerTable values('{CustNameTb.Text}','{CustAddTb.Text}','{CustPhoneTb.Text}')";
                    SqlCommand sqlCommand = new SqlCommand(query,Con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    
                    Con.Close();
                    populate();
                    clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //shows data in the table
        private void populate()
        {
            Con.Open() ;
            string query = "select * from CustomerTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            var ds=new DataSet();
            adapter.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close() ;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }
        //click on table data to fill 
        int custkey = 0;
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustAddTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (CustPhoneTb.Text == "")
            {
                custkey = 0;
            }
            else
            {
                custkey = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        //clears all the field
        private void clear()
        {
            custkey = 0;
            CustNameTb.Text = "";
            CustAddTb.Text = "";
            CustPhoneTb.Text = "";

        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            clear();
        }
        // delete a customer entry
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (custkey == 0)
            {
                MessageBox.Show("Select the Customer to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"delete from CustomerTable where CustId={custkey};";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
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
        // update or edit data button
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"update CustomerTable set CustName='{CustNameTb.Text}',CustAdd='{CustAddTb.Text}',CustPhone='{CustPhoneTb.Text}' where CustId={custkey};";
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
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
