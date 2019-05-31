using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Double value = 0; 
        String operation = "";
        bool operation_pressed = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_Click_1(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            result.Text =  "1"; 
        }

        private void button_click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            result.Text =  b.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            
           
            Button b = (Button)sender;
            result.Text = result.Text + "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;


                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch
            operation_pressed = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button_Click2(object sender, EventArgs e)
        {

        }

        private void button_Click3(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            result.Text =  "3";
        }

        private void button_Click4(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text =  "4";
        }

        private void button_Click5(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            result.Text = "5";
        }

        private void button_Click6(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            result.Text =  "6";
        }

        private void button_Click7(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            result.Text = "7";
        }

        private void button_Click8(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            result.Text =  "8";
        }

        private void button_Click9(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            result.Text ="9";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            result.Text = "0"; 
        }

        private void button_click10(object sender, EventArgs e)
        {

            
            Button b = (Button)sender;
            result.Text = result.Text + ".";
        }

        private void button_Click_2(object sender, EventArgs e)
        {
           
            result.Text =  "2";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;  
            value = Double.Parse(result.Text);
            operation_pressed = true; 
        }
    }
}
