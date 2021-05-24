    using System;
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
                // The text box text is read and used as the radius
                double SphereR = double.Parse(textBox3.Text);
                // This code works out the surface area and volume using the radius
                double SSA = 4 * Math.PI * (SphereR * SphereR);
                double SV = 1.333333333333333333 * Math.PI * (SphereR * SphereR * SphereR);
                // The surface area and volume are added onto the labels
                label6.Text = "Surface area = " + SSA;
                label7.Text = "Volume = " + SV;
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");
            }

            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                double ConeR = double.Parse(textBox4.Text);
                double ConeH = double.Parse(textBox5.Text);
                double ConeSA = Math.PI * ConeR * (ConeR + (Math.Sqrt(ConeH * ConeH + ConeR * ConeR)));
                double ConeV = Math.PI * (ConeR * ConeR) * (ConeH / 3);
                label8.Text = "Surface area = " + ConeSA;
                label9.Text = "Volume = " + ConeV;
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");
            }
           
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            try
            {
                double CylinderR = double.Parse(textBox7.Text);
                double CylinderH = double.Parse(textBox8.Text);
                double CylinderSA = 2 * Math.PI * CylinderR * CylinderH + 2 * Math.PI * (CylinderR * CylinderR);
                double CylinderV = Math.PI * (CylinderR * CylinderR) * CylinderH;
                label13.Text = "Surface area = " + CylinderSA;
                label14.Text = "Volume = " + CylinderV;
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");
            }
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                double CubeL = double.Parse(textBox9.Text);
                double CubeSA = 6 * (CubeL * CubeL);
                double CubeV = CubeL * CubeL * CubeL;
                label19.Text = "Surface area =" + CubeSA;
                label20.Text = "Volume =" + CubeV;
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                double CuboidL = double.Parse(textBox10.Text);
                double CuboidW = double.Parse(textBox11.Text);
                double CuboidH = double.Parse(textBox12.Text);
                double CuboidSA = (2 * CuboidL * CuboidW) + (2 * CuboidL * CuboidH) + (2 * CuboidW * CuboidH);
                double CuboidV = (CuboidW * CuboidH) * CuboidL;
                label24.Text = "Surface area = " + CuboidSA;
                label25.Text = "Volume = " + CuboidV; 
            }
            catch
            {
                // Shows an message if an error occurs
                MessageBox.Show("You numbers are wrong, check again");
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }
    }
         
    }
   
    
