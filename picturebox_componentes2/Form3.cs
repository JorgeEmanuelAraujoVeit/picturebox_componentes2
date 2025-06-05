using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox_componentes2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.oxigenio;

            if (checkBox1.Checked == false)
            {
                pictureBox1.Image = null;
            }

            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hidrogenio;

            if (checkBox3.Checked == false)
            {
                pictureBox2.Image = null;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.Nacl;

            if (checkBox2.Checked == false)
            {
                pictureBox3.Image = null;
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
