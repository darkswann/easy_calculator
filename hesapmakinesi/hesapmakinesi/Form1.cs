﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2(); 
            fr2.ShowDialog();
            MessageBox.Show("Dikkat", "Uyarı", MessageBoxButtons.AbortRetryIgnore);
            button11.Visible = false;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
