﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            this.answer.Text = "0";
            this.ConvertResult.Text = "0";
        }

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        private void answer_TextChanged(object sender, EventArgs e) // Answer Textbox
        {
            
        }

        private void button10_Click(object sender, EventArgs e) // 0
        {
            this.answer.Text = "";
            input += '0';
            this.answer.Text += input;
        }

        private void button1_Click(object sender, EventArgs e) // 1
        {
            this.answer.Text = "";
            input += '1';
            this.answer.Text += input;
        }

        private void button2_Click(object sender, EventArgs e) // 2
        {
            this.answer.Text = "";
            input += '2';
            this.answer.Text += input;
        }

        private void button3_Click(object sender, EventArgs e) // 3
        {
            this.answer.Text = "";
            input += '3';
            this.answer.Text += input;
        }

        private void button4_Click(object sender, EventArgs e) // 4
        {
            this.answer.Text = "";
            input += '4';
            this.answer.Text += input;
        }

        private void button5_Click(object sender, EventArgs e) // 5
        {
            this.answer.Text = "";
            input += '5';
            this.answer.Text += input;
        }

        private void button6_Click(object sender, EventArgs e) // 6
        {
            this.answer.Text = "";
            input += '6';
            this.answer.Text += input;
        }

        private void button7_Click(object sender, EventArgs e) // 7
        {
            this.answer.Text = "";
            input += '7';
            this.answer.Text += input;
        }

        private void button8_Click(object sender, EventArgs e) // 8
        {
            this.answer.Text = "";
            input += '8';
            this.answer.Text += input;
        }

        private void button9_Click(object sender, EventArgs e) // 9
        {
            this.answer.Text = "";
            input += '9';
            this.answer.Text += input;
        }

        private void button11_Click(object sender, EventArgs e) // ,
        {
            this.answer.Text = "";
            input += ',';
            this.answer.Text += input;
        }

        private void Percent_Click(object sender, EventArgs e) // %
        {
            answer.Text = (((System.Convert.ToDouble(input) / 100) * System.Convert.ToDouble(operand1))).ToString();
            input =(answer.Text);
        }

        private void button13_Click(object sender, EventArgs e) // +
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e) // -
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e) // *
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e) // /
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void ClearEntry_Click(object sender, EventArgs e) // Clear Entry
        {
            string originalstring = answer.Text;
            string removelast = originalstring.Substring(0, originalstring.Length - 1);
            answer.Text = removelast;

            if (removelast.Length <= 0)
            {
                ClearEntry.Enabled = false;
                answer.Text = "0";
                this.input = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
                ClearEntry.Enabled = true;
            }                      
        }

        private void Clear_Click(object sender, EventArgs e) // Clear
        {
            this.answer.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.answer.Text = "0";
            this.ConvertResult.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e) // Equals
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                answer.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                answer.Text = result.ToString();
            }

            else if (operation == '*')
            {
                result = num1 * num2;
                answer.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    answer.Text = result.ToString();
                }
                else
                {
                    answer.Text = "Cannot divide by zero!";
                }
            }
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e) // Currency Converter
        {
            double convertinput = 0.0;
            double.TryParse(answer.Text, out convertinput);

            if (comboBox1.SelectedItem.ToString() == "Euro" && comboBox2.SelectedItem.ToString() == "American Dollar")
            {
                ConvertResult.Text = (convertinput * 1.1560).ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Euro" && comboBox2.SelectedItem.ToString() == "Great Britain Pound")
            {
                ConvertResult.Text = (convertinput * 0.9018).ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "American Dollar" && comboBox2.SelectedItem.ToString() == "Euro")
            {
                ConvertResult.Text = (convertinput * 0.8651).ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "American Dollar" && comboBox2.SelectedItem.ToString() == "Great Britain Pound")
            {
                ConvertResult.Text = (convertinput * 0.7801).ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Great Britain Pound" && comboBox2.SelectedItem.ToString() == "Euro")
            {
                ConvertResult.Text = (convertinput * 1.1089).ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Great Britain Pound" && comboBox2.SelectedItem.ToString() == "American Dollar")
            {
                ConvertResult.Text = (convertinput * 1.2818).ToString();
            }
        }

        private void ConvertResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
