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
using System.IdentityModel.Protocols.WSTrust;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Xml.Linq;

namespace Booking_System
{
    public partial class Staff : Form
    {
        string name;
        public Staff(string name)
        {
            InitializeComponent();
            this.name = name;
            //Program.ChangeFont(this);
            label1.Font = new Font(Program.pfc2.Families[0], label1.Font.Size);
            label12.Font = new Font(Program.pfc2.Families[0], label12.Font.Size);
            but1.Font = new Font(Program.pfc.Families[1], but1.Font.Size);
            but2.Font = new Font(Program.pfc.Families[1], but2.Font.Size);
            but3.Font = new Font(Program.pfc.Families[1], but3.Font.Size);
            but4.Font = new Font(Program.pfc.Families[1], but4.Font.Size);
            but5.Font = new Font(Program.pfc.Families[1], but5.Font.Size);
            but6.Font = new Font(Program.pfc.Families[1], but6.Font.Size);
            label2.Font = new Font(Program.pfc.Families[1], label2.Font.Size);
            label3.Font = new Font(Program.pfc.Families[1], label3.Font.Size);
            label11.Font = new Font(Program.pfc.Families[1], label11.Font.Size);
            label4.Font = new Font(Program.pfc.Families[1], label4.Font.Size);
            label5.Font = new Font(Program.pfc.Families[1], label5.Font.Size);

            StaffNameTb.Font = new Font(Program.pfc.Families[1], StaffNameTb.Font.Size);
            StaffPhoneTb.Font = new Font(Program.pfc.Families[1], StaffPhoneTb.Font.Size);
            StaffPasswordTb.Font = new Font(Program.pfc.Families[1], StaffPasswordTb.Font.Size);
            StaffGenderCb.Font = new Font(Program.pfc.Families[1], StaffGenderCb.Font.Size);

        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");
        MongoClient client = new MongoClient("mongodb+srv://Form:formpass@cluster0.ir7prkj.mongodb.net/?retryWrites=true&w=majority");

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
                //staffKey = 0;
                key = new ObjectId();
            }
            else
            {
                //staffKey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
                key = new ObjectId(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        //add
        private void add()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<StaffSchema> collection = database.GetCollection<StaffSchema>("Staff");

            try
            {


                StaffSchema newStaff = new StaffSchema
                {
                    //Bid = Guid.NewGuid().ToString(),
                    StaffId = ObjectId.GenerateNewId(),
                    StaffName = StaffNameTb.Text,
                    StaffPhone = StaffPhoneTb.Text,
                    StaffGender = StaffGenderCb.Text,
                    StaffPassword = StaffPasswordTb.Text,


                };


                collection.InsertOne(newStaff);


                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPasswordTb.Text == "" || StaffGenderCb.SelectedIndex == -1)
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
                //    string query = $"insert into StaffTable values('{StaffNameTb.Text}','{StaffPhoneTb.Text}','{StaffGenderCb.SelectedItem.ToString()}','{StaffPasswordTb.Text}')";
                //    SqlCommand sqlCommand = new SqlCommand(query, Con);
                //    sqlCommand.ExecuteNonQuery();
                //    MessageBox.Show("Staff Successfully Added");

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
        // show data in table
        private void populate()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<StaffSchema> collection = database.GetCollection<StaffSchema>("Staff");

            List<StaffSchema> documents = collection.Find(new BsonDocument()).ToList();

            // Bind the documents to the DataGridView
            StaffDGV.DataSource = documents;


            //Con.Open();
            //string query = "select * from StaffTable";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            //var ds = new DataSet();
            //adapter.Fill(ds);
            //StaffDGV.DataSource = ds.Tables[0];
            //Con.Close();
        }
        // clear all fields
        //int staffKey = 0;
        ObjectId key = new ObjectId();
        private void clear()
        {
            //custkey = 0;
            StaffNameTb.Text = "";
            StaffPhoneTb.Text = "";
            StaffPasswordTb.Text = "";
            StaffGenderCb.SelectedIndex = -1;
            key = new ObjectId();
            //staffKey = 0;

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

        private void delete()
        {

            try
            {
                IMongoDatabase database = client.GetDatabase("BookingDB");
                IMongoCollection<StaffSchema> collection = database.GetCollection<StaffSchema>("Staff");

                // Define the filter to identify the document to delete
                var filter = Builders<StaffSchema>.Filter.Eq("StaffId", ObjectId.Parse(key.ToString()));

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
            if (/*staffKey == 0*/ key.ToString() == "000000000000000000000000")
            {
                MessageBox.Show("Select the Staff to be deleted");
            }
            else
            {
                delete();
                populate();
                clear();
                //try
                //{
                //    Con.Open();
                //    string query = $"delete from StaffTable where StaffId={staffKey};";
                //    SqlCommand cmd = new SqlCommand(query, Con);
                //    cmd.ExecuteNonQuery();
                //    MessageBox.Show("Staff Deleted Successfully");
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
        //update and edit
        private void update()
        {
            try
            {
                IMongoDatabase database = client.GetDatabase("BookingDB");
                IMongoCollection<StaffSchema> collection = database.GetCollection<StaffSchema>("Staff");

                // Define the filter to identify the document to update
                var filter = Builders<StaffSchema>.Filter.Eq("StaffId", ObjectId.Parse(key.ToString()));

                // Define the update operation
                var update = Builders<StaffSchema>.Update.Set("StaffName", StaffNameTb.Text)
                                                          .Set("StaffPhone", StaffPhoneTb.Text)
                                                          .Set("StaffGender", StaffGenderCb.Text)
                                                          .Set("StaffPassword", StaffPasswordTb.Text);

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
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPasswordTb.Text == ""||StaffGenderCb.SelectedIndex==-1 )
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
                //    string query = $"update StaffTable set StaffName='{StaffNameTb.Text}',StaffPhone='{StaffPhoneTb.Text}',StaffPassword='{StaffPasswordTb.Text}',StaffGender='{StaffGenderCb.SelectedItem.ToString()}' where StaffId={staffKey};";
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
            Admin admin=new Admin(name);
            admin.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm("Admin");
            //home.name = "Hello Admin, welcome to booking app";
            home.Show();
            this.Hide();
        }

        private void StaffNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
