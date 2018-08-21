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
    public partial class Adabar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd;
        string imagelocation = "";
        public Adabar()
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
            Landowner_View lv = new Landowner_View();
            lv.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *jpeg; *.gif; *.bmp)| *jpg; *.png; *jpeg; *.gif; *.bmp";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                imagelocation = open.FileName.ToString();
                pictureBox1.ImageLocation = imagelocation;
                button1.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *jpeg; *.gif; *.bmp)| *jpg; *.png; *jpeg; *.gif; *.bmp";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                imagelocation = open.FileName.ToString();
                pictureBox2.ImageLocation = imagelocation;
                button2.Hide();

            }
        }

        private void Adabar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlaceRent_Click(object sender, EventArgs e)
        {
            byte[] images1 = null;
            byte[] images2 = null;
            FileStream stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images1 = brs.ReadBytes((int)stream.Length);
            images2 = brs.ReadBytes((int)stream.Length);
            if (textBoxBedrooms.Text != "" && textBoxAddress.Text != "" && textBoxSize.Text != "" && textBoxRentAmount.Text != "")
            {
                cmd = new SqlCommand("insert into Table_Adabar(BedRooms,Address,Size,RentAmount,Image1,Image2,Area) values(@bedrooms,@address,@size,@rent_amount,@images1,@images2,@area)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@bedrooms", textBoxBedrooms.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@size", textBoxSize.Text);
                cmd.Parameters.AddWithValue("@rent_amount", textBoxRentAmount.Text);
                cmd.Parameters.AddWithValue("@images1", images1);
                cmd.Parameters.AddWithValue("@images2", images2);
                cmd.Parameters.AddWithValue("@area", textBoxArea.Text);
                //cmd.Parameters.AddWithValue("@image1", pictureBox1.Image);
                //cmd.Parameters.AddWithValue("@image2", pictureBox2.Image);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rent Has Been Places");
                //DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
    }
}
