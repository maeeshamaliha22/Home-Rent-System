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
    public partial class Home_renter_view : Form
    {
        public Home_renter_view()
        {
            InitializeComponent();
        }

        private void Home_renter_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void buttonMirpur_Click(object sender, EventArgs e)
        {
            buttonAdabar1.Hide();
            buttonAdabar2.Hide();
            buttonAdabar3.Hide();
            buttonMalibagh1.Hide();
            buttonMalibagh2.Hide();
            buttonMalibagh3.Hide();
            pictureBoxMalibagh.Hide();
            pictureBoxAdabar.Hide();

            buttonMirpur1.Show();
            buttonMirpur2.Show();
            buttonMirpur3.Show();
            pictureBoxMirpur.Show();
        }

        private void buttonMalibagh_Click(object sender, EventArgs e)
        {
            buttonAdabar1.Hide();
            buttonAdabar2.Hide();
            buttonAdabar3.Hide();
            buttonMirpur1.Hide();
            buttonMirpur2.Hide();
            buttonMirpur3.Hide();
            pictureBoxAdabar.Hide();
            pictureBoxMirpur.Hide();

            buttonMalibagh1.Show();
            buttonMalibagh2.Show();
            buttonMalibagh3.Show();
            pictureBoxMalibagh.Show();
        }

        private void buttonAdabar_Click(object sender, EventArgs e)
        {
            buttonMalibagh1.Hide();
            buttonMalibagh2.Hide();
            buttonMalibagh3.Hide();
            buttonMirpur1.Hide();
            buttonMirpur2.Hide();
            buttonMirpur3.Hide();

            buttonAdabar1.Show();
            buttonAdabar2.Show();
            buttonAdabar3.Show();
            pictureBoxMalibagh.Hide();
            pictureBoxMirpur.Hide();
            pictureBoxAdabar.Show();
        }

        private void Home_renter_view_Load(object sender, EventArgs e)
        {
            buttonAdabar1.Hide();
            buttonAdabar2.Hide();
            buttonAdabar3.Hide();
            buttonMalibagh1.Hide();
            buttonMalibagh2.Hide();
            buttonMalibagh3.Hide();
            buttonMirpur1.Hide();
            buttonMirpur2.Hide();
            buttonMirpur3.Hide();
            pictureBoxAdabar.Hide();
            pictureBoxMalibagh.Hide();
            pictureBoxMirpur.Hide();
        }

        private void buttonMalibagh1_Click(object sender, EventArgs e)
        {
            Malibagh1 m1 = new Malibagh1();
            m1.Show();
            this.Hide();
        }

        private void buttonMalibagh2_Click(object sender, EventArgs e)
        {
            Malibagh2 m2 = new Malibagh2();
            m2.Show();
            this.Hide();
        }

        private void buttonMalibagh3_Click(object sender, EventArgs e)
        {
            Malibagh3 m3 = new Malibagh3();
            m3.Show();
            this.Hide();
        }

        private void buttonMirpur3_Click(object sender, EventArgs e)
        {
            Mirpur3 mr3 = new Mirpur3();
            mr3.Show();
            this.Hide();
        }

        private void buttonAdabar2_Click(object sender, EventArgs e)
        {
            Adabar2 a2 = new Adabar2();
            a2.Show();
            this.Hide();
        }

        private void buttonMirpur1_Click(object sender, EventArgs e)
        {
            Mirpur1 mr1 = new Mirpur1();
            mr1.Show();
            this.Hide();
        }

        private void buttonAdabar3_Click(object sender, EventArgs e)
        {
            Adabar3 a3 = new Adabar3();
            a3.Show();
            this.Hide();
        }

        private void buttonAdabar1_Click(object sender, EventArgs e)
        {
            Adabar1 a1 = new Adabar1();
            a1.Show();
            this.Hide();
        }

        private void buttonMirpur2_Click(object sender, EventArgs e)
        {
            Mirpur2 mr2 = new Mirpur2();
            mr2.Show();
            this.Hide();
        }
    }
}
