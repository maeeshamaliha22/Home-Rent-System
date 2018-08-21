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

    public partial class Create_Account : Form
    {
        private DataClasses1DataContext db = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Govinda\documents\visual studio 2017\Projects\Home Rent System\Home Rent System\Home.mdf;Integrated Security=True;Connect Timeout=30");
        public Create_Account()
        {
            InitializeComponent();
        }

        private void Create_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            UserList ul = new UserList();
            ul.UserId = textUserID.Text;
            
            ul.Name = textName.Text;
            ul.Password = textPassword.Text;
            ul.ContactNo = textContactNo.Text;
            if(radioRenter.Checked)
            {
                ul.UserType = radioRenter.Text;
            }
            if(radioLandower.Checked)
            {
                ul.UserType = radioLandower.Text;
            }

            
            db.UserLists.InsertOnSubmit(ul);
            db.SubmitChanges();
            MessageBox.Show("Account Created!");
        }
    }
}
