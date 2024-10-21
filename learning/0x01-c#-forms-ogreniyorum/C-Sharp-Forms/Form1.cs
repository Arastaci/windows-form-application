using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox.Items.Add("Gaziantep");
            ComboBox.Items.Add("Kahramanmaras");
            ComboBox.Items.Add("Ankara");
            ComboBox.Items.Add("Istanbul");
            ComboBox.Items.Add("Duzce");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (username == "JohnDoe")
            {
                if (password == "JohnDoe123")
                {
                    result.Text = "Successfully logged in! ";
                }
                else
                {
                    result.Text = "Username or password incorrect!";
                }
            }
            else
            {
                result.Text = "Username or password incorrect!";
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = ComboBox.SelectedItem.ToString();
            City.Text = $"{selectedCity} ikamet ettiginiz sehir";
        }
    }

}