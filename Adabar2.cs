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
    public partial class Adabar2 : Form
    {
        DataClasses1DataContext ul = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30");

        public Adabar2()
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
               // button2.Hide();

            }
        }*/

        private void Adabar2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table_Adabar s = ul.Table_Adabars.SingleOrDefault(x => x.Area == "2");
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

        private void Adabar2_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
        }
    }
}
