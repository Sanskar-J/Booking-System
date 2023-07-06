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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanskar\Documents\BookingDB.mdf;Integrated Security=True;Connect Timeout=30");

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
            Con.Open();
            SqlCommand sqc = new SqlCommand("select CustId from CustomerTable",Con);
            SqlDataReader rdr;
            rdr=sqc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId",typeof(string));
            dt.Load(rdr);
            CustomerIdCb.ValueMember = "CustId";
            CustomerIdCb.DataSource = dt;
            Con.Close();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            getCustId();
        }
        private void fetchCustName()
        {
            Con.Open();
            string query = $"select * from CustomerTable where CustId={CustomerIdCb.SelectedValue.ToString()}";
            SqlCommand sqc = new SqlCommand(query, Con);
            DataTable dataTable = new DataTable(); 
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqc);
            sqlDataAdapter.Fill(dataTable);
            foreach(DataRow dr in dataTable.Rows) {
                CustNameLbl.Text = $" {dr["CustName"].ToString()}";
            }
            Con.Close();
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

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (CustNameLbl.Text == "" || FunctionTb.Text == "" || VenueTb.Text == "" || TimeCb.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    if(PhotographyCb.Checked) { sb.Append("Photography "); }
                    if (VideographyCb.Checked) { sb.Append("Videography "); }
                    if (CameraCb.Checked) { sb.Append("Camera "); }
                    Con.Open();
                    string query = $"insert into BookingsTable values('{DatePicker.Value.ToString("yyyy-MM-dd")}','{TimeCb.Text}','{CustNameLbl.Text}'," +
                        $"'{FunctionTb.Text}','{VenueTb.Text}','{sb.ToString()}','{Convert.ToInt32(incTotal.Text)}','{Convert.ToInt32(OtherCharges.Text)}'," +
                        $"'{Convert.ToInt32(Total.Text)}','{Convert.ToInt32(Advance.Text)}','{Convert.ToInt32(Balance.Text)}')";
                    SqlCommand sqlCommand = new SqlCommand(query, Con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Booking Successful");

                    Con.Close();
                    //populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
