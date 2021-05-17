﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Reads what text is in the force and angle textboxs
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                //Inputs the numbers into the equation
                double Fx = Force * cos(Angle);
                double Fy = Angle * sin(Angle);
                // Rewrites the answers into the label
                label5.Text = "Fy = " + Fy;
                label4.Text = "Fx = " + Fx;
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Reads what text is in the force and angle textboxs
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                //Inputs the numbers into the equation
                double Fx = Force * cos(Angle);
                double Fy = Angle * sin(Angle);
                // Rewrites the answers into the label
                label5.Text = "Fy = " + Fy;
                label4.Text = "Fx = " + Fx;
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
          try
            {
                double SphereR = double.Parse(textBox3.Text);
                double SSA = 4 * Math.PI * (SphereR * SphereR);
                double SV = 1.333333333333333333 * Math.PI * (SphereR * SphereR * SphereR);
                label6.Text = "Surface area = " + SSA;
                label7.Text = "Volume = " + SV;
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");
            }

            
        }
    }
         
    }
   
    
