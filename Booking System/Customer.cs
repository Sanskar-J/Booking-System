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
using System.Collections.ObjectModel;

namespace Booking_System
{
    public partial class Customer : Form
    {
        string name;
        public Customer(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        //exit button
        private void label12_Click(object sender, EventArgs e)
        {
            MainForm Home = new MainForm(name);
            Home.delete();
            Application.Exit();
        }
        // sql connector
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");
        MongoClient client = new MongoClient("mongodb+srv://Form:formpass@cluster0.ir7prkj.mongodb.net/?retryWrites=true&w=majority");

        // add customer button
        private void add()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<CustomerSchema> collection = database.GetCollection<CustomerSchema>("Customer");

            try
            {
                

                CustomerSchema newCustomer = new CustomerSchema
                {
                    //Bid = Guid.NewGuid().ToString(),
                    CustId = ObjectId.GenerateNewId(),
                    CustName = CustNameTb.Text,
                    CustAdd = CustAddTb.Text,
                    CustPhone = CustPhoneTb.Text,
                    

                };


                collection.InsertOne(newCustomer);


                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if(CustNameTb.Text=="" || CustAddTb.Text=="" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                add();
                populate();
                clear();
                //try
                //{
                //    Con.Open();
                //    string query = $"insert into CustomerTable values('{CustNameTb.Text}','{CustAddTb.Text}','{CustPhoneTb.Text}')";
                //    SqlCommand sqlCommand = new SqlCommand(query,Con);
                //    sqlCommand.ExecuteNonQuery();
                //    MessageBox.Show("Customer Successfully Added");
                    
                //    Con.Close();
                //    populate();
                //    clear();
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }
        //shows data in the table
        private void populate()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<CustomerSchema> collection = database.GetCollection<CustomerSchema>("Customer");

            List<CustomerSchema> documents = collection.Find(new BsonDocument()).ToList();

            // Bind the documents to the DataGridView
            CustomerDGV.DataSource = documents;
            //Con.Open() ;
            //string query = "select * from CustomerTable";
            //SqlDataAdapter adapter = new SqlDataAdapter(query,Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            //var ds=new DataSet();
            //adapter.Fill(ds);
            //CustomerDGV.DataSource = ds.Tables[0];
            //Con.Close() ;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }
        //click on table data to fill 
        //int custkey = 0;
        ObjectId key = new ObjectId();
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustAddTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (CustPhoneTb.Text == "")
            {
                //custkey = 0;
                key= new ObjectId();
            }
            else
            {
                key = new ObjectId(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
                //custkey = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        //clears all the field
        private void clear()
        {
            //custkey = 0;
            key=new ObjectId();
            CustNameTb.Text = "";
            CustAddTb.Text = "";
            CustPhoneTb.Text = "";

        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            clear();
        }
        // delete a customer entry
        private void delete()
        {

            try
            {
                IMongoDatabase database = client.GetDatabase("BookingDB");
                IMongoCollection<CustomerSchema> collection = database.GetCollection<CustomerSchema>("Customer");

                // Define the filter to identify the document to delete
                var filter = Builders<CustomerSchema>.Filter.Eq("CustId", ObjectId.Parse(key.ToString()));

                // Delete the document matching the filter
                DeleteResult result = collection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Document deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Document not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (/*custkey == 0*/ key.ToString()== "000000000000000000000000")
            {
                MessageBox.Show("Select the Customer to be deleted");
            }
            else
            {
                delete();
                populate();
                clear();
                //try
                //{
                //    Con.Open();
                //    string query = $"delete from CustomerTable where CustId={custkey};";
                //    SqlCommand cmd = new SqlCommand(query,Con);
                //    cmd.ExecuteNonQuery();
                //    MessageBox.Show("Customer Deleted Successfully");
                //    Con.Close();
                //    populate();
                //    clear();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }
        // update or edit data button
        private void update()
        {
            try
            {
                IMongoDatabase database = client.GetDatabase("BookingDB");
                IMongoCollection<CustomerSchema> collection = database.GetCollection<CustomerSchema>("Customer");

                // Define the filter to identify the document to update
                var filter = Builders<CustomerSchema>.Filter.Eq("CustId", ObjectId.Parse(key.ToString()));

                // Define the update operation
                var update = Builders<CustomerSchema>.Update.Set("CustName", CustNameTb.Text)
                                                          .Set("CustAdd", CustAddTb.Text)
                                                          .Set("CustPhone",CustPhoneTb.Text);

                // Update the document matching the filter
                UpdateResult result = collection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Document updated successfully!");
                }
                else
                {
                    MessageBox.Show("Document not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                update();
                populate();
                clear();
                //try
                //{
                //    Con.Open();
                //    string query = $"update CustomerTable set CustName='{CustNameTb.Text}',CustAdd='{CustAddTb.Text}',CustPhone='{CustPhoneTb.Text}' where CustId={custkey};";
                //    SqlCommand sqlCommand = new SqlCommand(query, Con);
                //    sqlCommand.ExecuteNonQuery();
                //    MessageBox.Show("Data Updated Successfully");
                    
                //    Con.Close();
                //    populate();
                //    clear();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm(name);
            home.Show();
            this.Hide();
        }
    }
}
