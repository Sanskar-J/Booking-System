using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Booking_System
{
    public partial class MainForm : Form
    {
        //public string name
        //{
        //    get { return helloLbl.Text; }
        //    set { helloLbl.Text = value; }
        //}
        string name;
        ObjectId key=new ObjectId();
        public MainForm(string name)
        {
            this.name = name;
            InitializeComponent();
            helloLbl.Text = $"Hello {name}, welcome to booking app";

        }
        MongoClient client = new MongoClient("mongodb+srv://Form:formpass@cluster0.ir7prkj.mongodb.net/?retryWrites=true&w=majority");

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ViewBooking vb = new ViewBooking(name);
            vb.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            delete();
            Application.Exit();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Booking bw = new Booking(name);
            bw.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login log = new Login(name);
            delete();
            log.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Customer cs=new Customer(name);
            cs.Show();
            this.Hide();
        }
        public void delete()
        {

            try
            {
                IMongoDatabase database = client.GetDatabase("BookingDB");
                IMongoCollection<LoginSchema> collection = database.GetCollection<LoginSchema>("Login");

                // Define the filter to identify the document to delete
                var filter = Builders<LoginSchema>.Filter.Eq("LoginName", name);

                // Delete the document matching the filter
                DeleteResult result = collection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("User Logged Out");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
