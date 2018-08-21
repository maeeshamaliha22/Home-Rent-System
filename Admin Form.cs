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
using MaterialSkin;

namespace Home_Rent_System
{
    public partial class Admin_Form : MaterialSkin.Controls.MaterialForm
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30;";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlDataAdapter adapt;
        DataTable dt;
        SqlCommand cmd;
        int Id = 0;

        public Admin_Form()
        {
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            DisplayData();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from UserList", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }


        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        private void ClearData()
        {
            textName.Text = "";
            textPassword.Text = "";
            textUserid.Text = "";
            textContactNo.Text = "";
            textUsertype.Text = "";
            
        }
        private void DisplayData()
        {
            con.Open();
            dt = new DataTable();
            adapt = new SqlDataAdapter("select * from UserList", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textUserid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textContactNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textUsertype.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void textSearch_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from UserList where Name like'" + textSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            if (textName.Text != "" && textPassword.Text != "" && textUserid.Text != "" && textContactNo.Text != "")
            {
                cmd = new SqlCommand("insert into UserList(Name,Password,UserId,ContactNo,UserType) values(@name,@password,@userid,@contactno,@usertype)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);
                cmd.Parameters.AddWithValue("@userid", textUserid.Text);
                cmd.Parameters.AddWithValue("@contactno", textContactNo.Text);
                cmd.Parameters.AddWithValue("@usertype", textUsertype.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                cmd = new SqlCommand("delete UserList where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to delete");
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (textName.Text != "" && textPassword.Text != "" && textUserid.Text != "" && textContactNo.Text != "" && textUsertype.Text != "")
            {
                cmd = new SqlCommand("update UserList set Name=@name, Password=@password, UserId=@userid, ContactNo=@contactno, UserType=@usertype where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);
                cmd.Parameters.AddWithValue("@userid", textUserid.Text);
                cmd.Parameters.AddWithValue("@contactno", textContactNo.Text);
                cmd.Parameters.AddWithValue("@usertype", textUsertype.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated!");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            textName.Text = "";
            textPassword.Text = "";
            textUserid.Text = "";
            textContactNo.Text = "";
            textUsertype.Text = "";
            MessageBox.Show("Cleared!");
            DisplayData();
            ClearData();
        }

        private void textSearch_TextChanged_1(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from UserList where Name like'" + textSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
