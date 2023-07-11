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
using System.Windows.Input;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Booking_System
{
    public partial class Login : Form
    {
        private string key = "h2T3F8d1G7k9K4p6";
        public string name;
        public Login(string name)
        {
            InitializeComponent();
            LoadSavedCredentials();
            
            mainLoginButton.Font = new Font(Program.pfc.Families[1], mainLoginButton.Font.Size);
            label1.Font = new Font(Program.pfc2.Families[0], label1.Font.Size);
            label2.Font = new Font(Program.pfc.Families[1], label2.Font.Size );
            
            label3.Font = new Font(Program.pfc.Families[1], label3.Font.Size);
            UsernameTb.Font = new Font(Program.pfc.Families[1], UsernameTb.Font.Size);
            PassTb.Font = new Font(Program.pfc.Families[1], PassTb.Font.Size);
            RememberMe.Font = new Font(Program.pfc.Families[1], RememberMe.Font.Size);
            AdminLogin.Font = new Font(Program.pfc.Families[1], AdminLogin.Font.Size);
            label12.Font= new Font(Program.pfc2.Families[0], label12.Font.Size);







            this.name = name;
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
            Admin admin=new Admin(name);
            admin.Show();
            this.Hide();
        }
        private void login()
        {
            string un = UsernameTb.Text;
            string pass = PassTb.Text;
            if (RememberMe.Checked)
            {
                SaveCredentials(un, pass);
            }
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<StaffSchema> collection = database.GetCollection<StaffSchema>("Staff");
            IMongoCollection<LoginSchema> collection2 = database.GetCollection<LoginSchema>("Login");

            try
            {
                // Define the filter to match the staff name and staff password
                var filter = Builders<StaffSchema>.Filter.Eq("StaffName", un) &
                             Builders<StaffSchema>.Filter.Eq("StaffPassword", pass);
                var filter2 = Builders<LoginSchema>.Filter.Eq("LoginName", un);
                long logged = collection2.CountDocuments(filter2);
                // Get the count of documents matching the filter
                long count = collection.CountDocuments(filter);
                if (logged == 1)
                {
                    MessageBox.Show("Account instance " +
                        "already logged in");
                }
                else if (count == 1 && logged==0)
                {
                    add();
                    
                    MainForm home = new MainForm(un);
                    //home.name = ;
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
        //save credentials at cache
        private void SaveCredentials(string username, string password)
        {
            // Encrypt the password
            //string encryptedPassword = EncryptString(password, key);

            // Save the credentials in application settings
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Password = password;
            //Properties.Settings.Default.Password = encryptedPassword;
            Properties.Settings.Default.Save();
        }
        // load saved creds 
        private void LoadSavedCredentials()
        {
            // Load the saved credentials from application settings
            string savedUsername = Properties.Settings.Default.Username;
            string encryptedPassword = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(savedUsername) && !string.IsNullOrEmpty(encryptedPassword))
            {
                // Decrypt the password
                //string savedPassword = DecryptString(encryptedPassword, key);

                UsernameTb.Text = savedUsername;
                PassTb.Text = encryptedPassword;
                //PassTb.Text = savedPassword;
                RememberMe.Checked = true;
            }
        }

        private string EncryptString(string plainText, string key)
        {
            byte[] encryptedBytes;
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(key, aes.KeySize / 8);
                aes.Key = keyDerivation.GetBytes(aes.KeySize / 8);
                aes.IV = keyDerivation.GetBytes(aes.BlockSize / 8);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    encryptedBytes = memoryStream.ToArray();
                }
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        private string DecryptString(string encryptedText, string key)
        {
            byte[] decryptedBytes;
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(key, aes.KeySize / 8);
                aes.Key = keyDerivation.GetBytes(aes.KeySize / 8);
                aes.IV = keyDerivation.GetBytes(aes.BlockSize / 8);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    decryptedBytes = memoryStream.ToArray();
                }
            }

            return Encoding.UTF8.GetString(decryptedBytes);
        }
        //login add functionality
        private void add()
        {
            IMongoDatabase database = client.GetDatabase("BookingDB");
            IMongoCollection<LoginSchema> collection = database.GetCollection<LoginSchema>("Login");

            try
            {


                LoginSchema newLogin = new LoginSchema
                {
                    //Bid = Guid.NewGuid().ToString(),
                    LoginId = ObjectId.GenerateNewId(),
                    LoginName = UsernameTb.Text,


                };


                collection.InsertOne(newLogin);


                //MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void AdminLogin_MouseHover(object sender, EventArgs e)
        {
            AdminLogin.BackColor = Color.White;
            AdminLogin.ForeColor= Color.Black;
        }

        private void AdminLogin_MouseLeave(object sender, EventArgs e)
        {
            AdminLogin.BackColor = Color.Black;
            AdminLogin.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
