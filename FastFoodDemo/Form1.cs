﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();

            //Thanks for watching Friends...
            //Please dont forget to Subscribe... :) :) :) 
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) { 
        {
            DialogResult dialog = MessageBox.Show("DO YOU REALLY WANT TO EXIT THE PROGAMME ?", "Exit", MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            { Application.Exit(); }
            else if (dialog==DialogResult.No)
            { }
                    }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("www.instagram.com");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("www.twitter.com");

        }
    }
}
