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
using MongoDB.Driver;
using MongoDB.Bson;

namespace Booking_System
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        MongoClient client = new MongoClient("mongodb+srv://Form:formpass@cluster0.ir7prkj.mongodb.net/?retryWrites=true&w=majority");

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PhotographyCb_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void PhotographyCb_CheckStateChanged(object sender, EventArgs e)
        {
            if (PhotographyCb.CheckState == CheckState.Checked){
                PhotographyPrice.Enabled = true;
            }
            else
            {
                PhotographyPrice.Enabled = false;
                PhotographyPrice.Text = "0";
            }
        }

        private void VideographyCb_CheckStateChanged(object sender, EventArgs e)
        {
            if (VideographyCb.CheckState == CheckState.Checked)
            {
                VideographyPrice.Enabled = true;
            }
            else
            {
                VideographyPrice.Enabled = false;
                VideographyPrice.Text = "0";
            }
        }

        private void CameraCb_CheckStateChanged(object sender, EventArgs e)
        {
            if (CameraCb.CheckState == CheckState.Checked)
            {
                CameraPrice.Enabled = true;
            }
            else
            {
                CameraPrice.Enabled = false;
                CameraPrice.Text = "0";
            }
        }

        private void IncludeCost_Click(object sender, EventArgs e)
        {
            int photography=0, videography=0, camera=0;
            if (PhotographyCb.Checked && PhotographyPrice.Text!="")
                photography = Convert.ToInt32(PhotographyPrice.Text);
            if (VideographyCb.Checked && VideographyPrice.Text != "")
                videography = Convert.ToInt32(VideographyPrice.Text);
            if (CameraCb.Checked && CameraPrice.Text != "")
                camera = Convert.ToInt32(CameraPrice.Text);
            int incTot = photography + videography + camera;
            incTotal.Text = ""+incTot;
            calcTotal();
        }
        private void onlyDigit(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PhotographyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(e);
        }

        private void VideographyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(e);
        }

        private void CameraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(e);
        }
        private void getCustId()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<CustomerSchema> collection = database.GetCollection<CustomerSchema>("Customer");
            List<CustomerSchema> customers = collection.Find(new BsonDocument()).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(string));
            
            CustomerIdCb.ValueMember = "CustId";
            CustomerIdCb.DataSource = dt;

            foreach (var customer in customers)
            {
                dt.Rows.Add(customer.CustId);
            }


            //Con.Open();
            //SqlCommand sqc = new SqlCommand("select CustId from CustomerTable",Con);
            //SqlDataReader rdr;
            //rdr=sqc.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("CustId",typeof(string));
            //dt.Load(rdr);
            //CustomerIdCb.ValueMember = "CustId";
            //CustomerIdCb.DataSource = dt;
            //Con.Close();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            getCustId();
        }
        private void fetchCustName()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<CustomerSchema> collection = database.GetCollection<CustomerSchema>("Customer");

            try
            {
                // Define the filter to match the customer ID
                var filter = Builders<CustomerSchema>.Filter.Eq("CustId", ObjectId.Parse(CustomerIdCb.SelectedValue.ToString()));

                // Retrieve the document matching the filter
                CustomerSchema customerBooking = collection.Find(filter).FirstOrDefault();
                
                if (customerBooking != null)
                {
                    string customerName = customerBooking.CustName;
                    CustNameLbl.Text = customerName;


                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //Con.Open();
            //string query = $"select * from CustomerTable where CustId={CustomerIdCb.SelectedValue.ToString()}";
            //SqlCommand sqc = new SqlCommand(query, Con);
            //DataTable dataTable = new DataTable(); 
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqc);
            //sqlDataAdapter.Fill(dataTable);
            //foreach(DataRow dr in dataTable.Rows) {
            //    CustNameLbl.Text = $" {dr["CustName"].ToString()}";
            //}
            //Con.Close();
        }
        private void CustomerIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }
        private void calcTotal()
        {
            int total = 0, bal = 0;
            int incTot = Convert.ToInt32(incTotal.Text);
            int other = 0;
            if(OtherCharges.Text!="")
                other=Convert.ToInt32(OtherCharges.Text);
            int adv = 0;
            if(Advance.Text!="")
                adv= Convert.ToInt32(Advance.Text);
            total = incTot + other;
            bal = total - adv;

            Total.Text = "" + total;
            Balance.Text = "" + bal;
        }
        private void OtherCharges_KeyUp(object sender, KeyEventArgs e)
        {
            calcTotal();
        }

        private void Advance_KeyUp(object sender, KeyEventArgs e)
        {
            calcTotal();
        }
        //clear function
        private void clear()
        {
            TimeCb.SelectedIndex = -1;
            VenueTb.Text = "";
            FunctionTb.Text = "";
            PhotographyCb.Checked = false;
            VideographyCb.Checked = false;
            CameraCb.Checked = false;
            incTotal.Text = "0";
            OtherCharges.Text = "0";
            Advance.Text = "0";
            Total.Text = "0";
            Balance.Text = "0";

        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void add()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<BookingSchema> collection = database.GetCollection<BookingSchema>("Booking");

            try
            {
                StringBuilder sb = new StringBuilder();
                if (PhotographyCb.Checked) { sb.Append("Photography "); }
                if (VideographyCb.Checked) { sb.Append("Videography "); }
                if (CameraCb.Checked) { sb.Append("Camera "); }

                BookingSchema newBooking = new BookingSchema
                {
                    Bid = ObjectId.GenerateNewId(),
                    BDate = DatePicker.Value,
                    BTime = TimeCb.Text,
                    CustName=CustNameLbl.Text,
                    Function=FunctionTb.Text,
                    Venue= VenueTb.Text,
                    EquipmentsIncluded=sb.ToString(),
                    IncludeCost= Convert.ToInt32(incTotal.Text),
                    OtherCharges= Convert.ToInt32(OtherCharges.Text),
                    GndTotal= Convert.ToInt32(Total.Text),
                    Advance= Convert.ToInt32(Advance.Text),
                    Balance= Convert.ToInt32(Balance.Text),

                };


                collection.InsertOne(newBooking);


                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (CustNameLbl.Text == "" || FunctionTb.Text == "" || VenueTb.Text == "" || TimeCb.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                add();
                clear();
                //try
                //{
                //    StringBuilder sb = new StringBuilder();
                //    if(PhotographyCb.Checked) { sb.Append("Photography "); }
                //    if (VideographyCb.Checked) { sb.Append("Videography "); }
                //    if (CameraCb.Checked) { sb.Append("Camera "); }
                //    Con.Open();
                //    string query = $"insert into BookingsTable values('{DatePicker.Value.ToString("yyyy-MM-dd")}','{TimeCb.Text}','{CustNameLbl.Text}'," +
                //        $"'{FunctionTb.Text}','{VenueTb.Text}','{sb.ToString()}','{Convert.ToInt32(incTotal.Text)}','{Convert.ToInt32(OtherCharges.Text)}'," +
                //        $"'{Convert.ToInt32(Total.Text)}','{Convert.ToInt32(Advance.Text)}','{Convert.ToInt32(Balance.Text)}')";
                //    SqlCommand sqlCommand = new SqlCommand(query, Con);
                //    sqlCommand.ExecuteNonQuery();
                //    MessageBox.Show("Booking Successful");

                //    Con.Close();
                //    //populate();
                //    clear();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainForm Home = new MainForm();
            Home.Show();
            this.Hide();
        }
    }
}
