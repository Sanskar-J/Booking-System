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
using MongoDB.Bson;
using MongoDB.Driver;

namespace Booking_System
{
    public partial class ViewBooking : Form
    {
        string name;
        public ViewBooking(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        MongoClient client = new MongoClient("mongodb+srv://Form:formpass@cluster0.ir7prkj.mongodb.net/?retryWrites=true&w=majority");

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<BookingSchema> collection = database.GetCollection<BookingSchema>("Booking");

            List<BookingSchema> documents = collection.Find(new BsonDocument()).ToList();

            // Bind the documents to the DataGridView
            BookingsDGV.DataSource = documents;

            //Con.Open();
            //string query = "select * from BookingsTable";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            //var ds = new DataSet();
            //adapter.Fill(ds);
            //BookingsDGV.DataSource = ds.Tables[0];
            //Con.Close();
        }
        private void ViewBooking_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MainForm Home = new MainForm(name);
            Home.delete();
            Application.Exit();
        }
        //delete entry
        //int bookKey = 0;
        ObjectId key = new ObjectId();
        private void delete()
        {

            try
            {
                IMongoDatabase database = client.GetDatabase("BookingDB");
                IMongoCollection<BookingSchema> collection = database.GetCollection<BookingSchema>("Booking");

                // Define the filter to identify the document to delete
                var filter = Builders<BookingSchema>.Filter.Eq("Bid", ObjectId.Parse(key.ToString()));

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
            if (/*bookKey == 0*/ key.ToString()== "000000000000000000000000")
            {
                MessageBox.Show("Select the Booking to be deleted");
            }
            else
            {
                delete();
                populate();
                //try
                //{
                //    Con.Open();
                //    string query = $"delete from BookingsTable where Bid={bookKey};";
                //    SqlCommand cmd = new SqlCommand(query, Con);
                //    cmd.ExecuteNonQuery();
                //    MessageBox.Show("Booking Deleted Successfully");
                //    Con.Close();
                //    populate();
                //    //clear();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            MainForm Home = new MainForm(name);
            Home.Show();
            this.Hide();
        }

        private void BookingsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookDate = BookingsDGV.SelectedRows[0].Cells[1].Value.ToString();

            if (bookDate == "")
            {
                //bookKey = 0;
                key = new ObjectId();
            }
            else
            {
                //bookKey = Convert.ToInt32(BookingsDGV.SelectedRows[0].Cells[0].Value.ToString());
                key = new ObjectId(BookingsDGV.SelectedRows[0].Cells[0].Value.ToString());
                if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String BookId = BookingsDGV.SelectedRows[0].Cells[0].Value.ToString();
            String BookDate = BookingsDGV.SelectedRows[0].Cells[1].Value.ToString().Substring(0,10);
            String BookTime = BookingsDGV.SelectedRows[0].Cells[2].Value.ToString();
            String BookCustName = BookingsDGV.SelectedRows[0].Cells[3].Value.ToString();
            String BookFunction = BookingsDGV.SelectedRows[0].Cells[4].Value.ToString();
            String BookVenue = BookingsDGV.SelectedRows[0].Cells[5].Value.ToString();
            String BookEquip = BookingsDGV.SelectedRows[0].Cells[6].Value.ToString();
            String BookIncCost = BookingsDGV.SelectedRows[0].Cells[7].Value.ToString();
            String BookOther = BookingsDGV.SelectedRows[0].Cells[8].Value.ToString();
            String BookGrandTot = BookingsDGV.SelectedRows[0].Cells[9].Value.ToString();
            String BookAdvance = BookingsDGV.SelectedRows[0].Cells[10].Value.ToString();
            String BookBalance = BookingsDGV.SelectedRows[0].Cells[11].Value.ToString();


            e.Graphics.DrawString("Booking Summary", new Font("Bebas Neue", 30,FontStyle.Regular),Brushes.Red,new Point(250));

            e.Graphics.DrawString("Booking Id: "+BookId, new Font("Bahnschrift",20,FontStyle.Regular),Brushes.Black,new Point(130,150));
            e.Graphics.DrawString("Booking Date: " + BookDate, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(130, 200));
            e.Graphics.DrawString("Booking Time: " + BookTime, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString("Name: " + BookCustName, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(130, 250));
            e.Graphics.DrawString("Function: " + BookFunction, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(500, 250));
            e.Graphics.DrawString("Venue: " + BookVenue, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(130, 300));
            e.Graphics.DrawString("Equipments: " + BookEquip, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(130, 350));
            e.Graphics.DrawString("Equipments Cost: " + BookIncCost, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(130, 400));
            e.Graphics.DrawString("Other Costs: " + BookOther, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(130, 650));
            e.Graphics.DrawString("Total: " + BookGrandTot, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(130, 700));
            e.Graphics.DrawString("Advance: " + BookAdvance, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(500, 650));
            e.Graphics.DrawString("Balance: " + BookBalance, new Font("Bahnschrift", 20, FontStyle.Regular), Brushes.Black, new Point(500, 700));
            Pen blackPen = new Pen(Color.Black, 3);

            // Create location and size of rectangle.
            


            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, 65, 95, 800, 450);
            e.Graphics.DrawRectangle(blackPen, -30, 595, 800, 450);

        }
    }
}
