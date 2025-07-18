﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Hidrogênio");
                listBox1.Items.Add("Água");
                listBox1.Items.Add("Sódio");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Dalton");
            listBox1.Items.Add("Thomson");
            listBox1.Items.Add("Rutherford");
            listBox1.Items.Add("Bohr");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Dalton")
            {
                pictureBox1.Image = Properties.Resources.Dalton;
            }
            else if (listBox1.Text == "Thomson")
            {
                pictureBox1.Image = Properties.Resources.Thomson;
            }
            else if (listBox1.Text == "Rutherford")
            {
                pictureBox1.Image = Properties.Resources.rutherford;
            }
            else if (listBox1.Text == "Bohr")
            {
                pictureBox1.Image = Properties.Resources.bohr;
            }
            else if (listBox1.Text == "Hidrogênio")
            {
                pictureBox1.Image = Properties.Resources.lewishidrogenio;
            }
            else if(listBox1.Text == "Água")
            {
                pictureBox1.Image = Properties.Resources.h2o;
            }
            else if (listBox1.Text == "Sódio")
            {
                pictureBox1.Image = Properties.Resources.naclestrutara;
            }
            else
            {
                pictureBox1.Image = null; // Clear the image if no match found
            }
        }
    }
}
