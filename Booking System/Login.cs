using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Web.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Booking_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MongoClient client = new MongoClient("mongodb+srv://Form:formpass@cluster0.ir7prkj.mongodb.net/?retryWrites=true&w=majority");
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");
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
        private void login()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<StaffSchema> collection = database.GetCollection<StaffSchema>("Staff");
            try
            {
                // Define the filter to match the staff name and staff password
                var filter = Builders<StaffSchema>.Filter.Eq("StaffName", UsernameTb.Text) &
                             Builders<StaffSchema>.Filter.Eq("StaffPassword", PassTb.Text);

                // Get the count of documents matching the filter
                long count = collection.CountDocuments(filter);
                if (count == 1)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(UsernameTb.Text=="" || PassTb.Text=="")
                MessageBox.Show("Please Enter Credentials");
            else
            {
                login();
                //try
                //{
                //    Con.Open();
                //    string query = $"select count(*) from StaffTable where StaffName='{UsernameTb.Text}' and StaffPassword='{PassTb.Text}' ";
                //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Con);
                //    DataTable dt = new DataTable();
                //    sqlDataAdapter.Fill(dt);
                //    if (dt.Rows[0][0].ToString().Equals("1"))
                //    {
                //        MainForm home = new MainForm();
                //        home.Show();
                //        this.Hide();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Incorrect Credentials");
                //        UsernameTb.Text = "";
                //        PassTb.Text = "";
                //    }

                //    Con.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            
        }
    }
}
