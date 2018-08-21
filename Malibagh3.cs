using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Rent_System
{

    public partial class Malibagh3 : Form
    {
        DataClasses1DataContext ul = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30");

        public Malibagh3()
        {
            InitializeComponent();
        }

        private void Malibagh3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            Table_Malibagh s = ul.Table_Malibaghs.SingleOrDefault(x => x.Area == "3");
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

        private void Malibagh3_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void textBoxBedrooms_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *jpeg; *.gif; *.bmp)| *jpg; *.png; *jpeg; *.gif; *.bmp";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                //button1.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *jpeg; *.gif; *.bmp)| *jpg; *.png; *jpeg; *.gif; *.bmp";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);
                //button2.Hide();

            }
        }*/
    }
}
