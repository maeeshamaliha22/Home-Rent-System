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
    public partial class Login_Form : Form
    {
        DataClasses1DataContext ul = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30");

        public Login_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_username_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s2 = textBox2.Text;
            var str = from a2 in ul.UserLists
                      where a2.UserId == s && a2.Password == s2

                      select a2;
            UserList pa = str.First();
            s2 = pa.Password.ToString();
            string s3 = pa.UserType.ToString();


            try
            {
                if (s.Equals(textBox1.Text) && s2.Equals(textBox2.Text) && s3.Equals("Admin"))
                {

                    Admin_Form af = new Admin_Form();
                    af.Show();
                    this.Hide();

                }

                else if (s.Equals(textBox1.Text) && s2.Equals(textBox2.Text) && s3.Equals("Landowner"))
                {
                    Landowner_View lv = new Landowner_View();
                    lv.Show();
                    this.Hide();
                }

                else if (s.Equals(textBox1.Text) && s2.Equals(textBox2.Text) && s3.Equals("Home Renter"))
                {
                    Home_renter_view hrv = new Home_renter_view();
                    hrv.Show();
                    this.Hide();

                }

            }
            catch(Exception)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please enter a valid input");
                }
            }
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Account ca = new Create_Account();
            ca.Show();
            this.Hide();
        }

    }
}
