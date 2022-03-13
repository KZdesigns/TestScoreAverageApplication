using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoreAverageApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            const double HIGH_SCORE = 95.0; // High score value
            double test1, test2, test3, average;

            // Get the scores from the text boxes
            test1 = double.Parse(test1TextBox.Text);
            test2 = double.Parse(test2TextBox.Text);
            test3 = double.Parse(test3TextBox.Text);

            // calculate the average
            average = (test1 + test2 + test3) / 3.0;

            // display the average, rouded to 2 decimal places.
            averageLabel.Text = average.ToString("n1");

            // if the average is a high sore, congratulate
            // the user with a message box.

            if (average > HIGH_SCORE)
            {
                MessageBox.Show("Congratulations! Great job!");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // clear all fields
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // reset the focus to test1
            test1TextBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // close program
            this.Close();
        }
    }
}
