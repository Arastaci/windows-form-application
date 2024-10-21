using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculateArea_Click_1(object sender, EventArgs e)
        {
            double radius;
            if (double.TryParse(txtRadius.Text, out radius) && radius > 0)
            {
                double area = Math.PI * Math.Pow(radius, 2); // Formula for area: πr²
                lblAreaResult.Text = "Area: " + area.ToString("F2");
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the radius.", "Invalid Input");
            }
        }
        private void btnCalculateCircumference_Click_1(object sender, EventArgs e)
        {
            double radius;
            if (double.TryParse(txtRadius.Text, out radius) && radius > 0)
            {
                double circumference = 2 * Math.PI * radius; // Formula for circumference: 2πr
                lblCircumferenceResult.Text = "Circumference: " + circumference.ToString("F2"); 
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the radius.", "Invalid Input");
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            lblRadiusValue.Text = txtRadius.Text;
        }
    }
}
