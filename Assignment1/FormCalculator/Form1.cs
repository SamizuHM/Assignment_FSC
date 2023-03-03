using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Single a = Convert.ToSingle(textBox1.Text);
            Single b = Convert.ToSingle(textBox2.Text);
            */
            
            double a;
            Console.Write("Enter the first number: ");
            if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Invalid input a.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double b;
            Console.Write("Enter the second number: ");
            if (!double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Invalid input b.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result;
            
            if (radioButton1.Checked == true)
            {
                result = a + b;
            }
            else if(radioButton2.Checked == true)
            {
                result = a - b;
            }
            else if (radioButton3.Checked == true)
            {
                result = a * b;
            }
            else if (radioButton4.Checked == true)
            {
                result = a / b;
            }
            else
            {
                MessageBox.Show("Operator error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            progressBar1.Value = 0;
            while (progressBar1.Value < progressBar1.Maximum)
            {
                this.progressBar1.PerformStep();
            }
            MessageBox.Show($"You got {result}", "Result");
        }

    }
}
