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
    public partial class Landowner_View : Form
    {
        public Landowner_View()
        {
            InitializeComponent();
            

        }

        private void Landowner_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void buttonMirpur1_Click(object sender, EventArgs e)
        {
            Mirpur m = new Mirpur();
            m.Show();
            this.Hide();
        }

        private void buttonMirpur2_Click(object sender, EventArgs e)
        {
            Mirpur m = new Mirpur();
            m.Show();
            this.Hide();
        }

        private void buttonMipur3_Click(object sender, EventArgs e)
        {
            Mirpur m = new Mirpur();
            m.Show();
            this.Hide();
        }

        private void Landowner_View_Load(object sender, EventArgs e)
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
            Malibagh m = new Malibagh();
            m.Show();
            this.Hide();
        }

        private void buttonAdabar1_Click(object sender, EventArgs e)
        {
            Adabar a1 = new Adabar();
            a1.Show();
            this.Hide();
        }

        private void buttonAdabar2_Click(object sender, EventArgs e)
        {
            Adabar a1 = new Adabar();
            a1.Show();
            this.Hide();
        }

        private void buttonAdabar3_Click(object sender, EventArgs e)
        {
            Adabar a1 = new Adabar();
            a1.Show();
            this.Hide();
        }

        private void buttonMalibagh2_Click(object sender, EventArgs e)
        {
            Malibagh m = new Malibagh();
            m.Show();
            this.Hide();
        }

        private void buttonMalibagh3_Click(object sender, EventArgs e)
        {
            Malibagh m = new Malibagh();
            m.Show();
            this.Hide();
        }

        private void pictureBoxAdabar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMalibagh_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMirpur_Click(object sender, EventArgs e)
        {

        }
    }
}
