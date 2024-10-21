using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addBox.Items.Add("JohnDoe");
            addBox.Items.Add("Wiener");
            addBox.Items.Add("Peter");
            addBox.Items.Add("Carlos");
        }

        private void add_Click(object sender, EventArgs e)
        {
            addBox.Items.Add(addArea.Text.ToString());
        }

        private void addBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIndex.Text = addBox.SelectedIndex.ToString();
            lblName.Text = addBox.SelectedItem.ToString();
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                string name = checkBox1.Text.ToString();
                addBox.Items.Add(name);
            } else{
                string name = checkBox1.Text.ToString();
                addBox.Items.Remove(name);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
