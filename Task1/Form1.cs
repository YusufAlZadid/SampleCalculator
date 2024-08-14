using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathOperations;
using InputValidationLibrary;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidInteger(textBox1.Text, out int number1) &&
                Validator.IsValidInteger(textBox2.Text, out int number2))
            {
                // Perform addition
                int result = number1 + number2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid integers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidInteger(textBox1.Text, out int number1) &&
                Validator.IsValidInteger(textBox2.Text, out int number2))
            {
                // Perform subtraction
                int result = number1 - number2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid integers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/



    }
}
