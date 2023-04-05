using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(!int.TryParse(MinNumberTextBox.Text, out int minNumber))
            {
                MessageBox.Show("Please enter a Number");
            } else if (!int.TryParse(MaxNumberTextBox.Text, out int maxNumber))
            {
                MessageBox.Show("Please enter a Number");
            } else
            {
                double randomNumber = (generateRandom(minNumber, maxNumber));
                ResultListBox.Items.Add($"Random number Generated :{randomNumber}");
            }

        }
        private int generateRandom(double min, double max)
        {
            Random random = new Random();
            return Convert.ToInt32(random.NextDouble() *max +min);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultListBox.Items.Clear(); 
        }
    }
}
