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
using System.IO;

namespace Home_Rent_System
{
    public partial class Mirpur1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30;");
        DataClasses1DataContext ul = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30");

        public Mirpur1()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home_renter_view hrv = new Home_renter_view();
            hrv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table_Mirpur s = ul.Table_Mirpurs.SingleOrDefault(x => x.Area == "1");
            if (s != null)
            {
                textBoxBedrooms.Text = s.BedRooms;
                textBoxAddress.Text = s.Address;
                textBoxSize.Text = s.Size;
                textBoxRentAmount.Text = s.RentAmount;
            }
            pictureBox1.Show();
            pictureBox2.Show();
        }

        private void Mirpur1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Mirpur1_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
        }
    }
}
