﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (SoA.Text != String.Empty && SoB.Text != String.Empty)
            {
                double a = double.Parse(SoA.Text);
                double b = double.Parse(SoB.Text);
                double c = a + b;
                KetQua.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(SoA.Text);
            double b = double.Parse(SoB.Text);
            double c = a - b;
            KetQua.Text = c.ToString();
        }
    }
}
