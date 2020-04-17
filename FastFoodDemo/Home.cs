using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SidePanel1.Height = button1.Height;
            SidePanel1.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button1.Height;
            SidePanel1.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button2.Height;
            SidePanel1.Top = button2.Top;
            mySecondCustmControl1.BringToFront();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button3.Height;
            SidePanel1.Top = button3.Top;
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button4.Height;
            SidePanel1.Top = button4.Top;
           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button5.Height;
            SidePanel1.Top = button5.Top;
          
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button6.Height;
            SidePanel1.Top = button6.Top;
          
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button7.Height;
            SidePanel1.Top = button7.Top;
           
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
