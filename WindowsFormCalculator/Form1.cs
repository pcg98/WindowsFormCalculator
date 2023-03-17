using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCalculator
{
    public partial class Calculator : Form
    {
        //Constructor
        public Calculator()
        {
            InitializeComponent();
        }
        //Var
        int num1, num2;
        string operation;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = ((Button)sender).Text;
        }
        //This listener is only for numbers buttons
        private void buttonNumbers_Click(object sender, EventArgs e)
        {
            //
            textDisplay.Text = textDisplay.Text + ((Button)sender).Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //If have something difers to 0...
            if (num1!=0) num1 = 0;
            if (num2 != 0) num2 = 0;
            //If operation was set...
            if (!String.IsNullOrEmpty(operation)) operation = "";
            //Clear the screen
            textDisplay.Clear();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            //Catch the second number
            if (!int.TryParse(textDisplay.Text, out num2) || num1<0) return;
            //Check if the operation and number 1 exists
            if (String.IsNullOrEmpty(operation) || num1 < 0) return;
            //If everything is fine...

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
            }
            //Show the result
            textDisplay.Text = num1 + " " + operation + " " + num2 + " = " + result;
            operation = "";

        }

            private void buttonOperations_Click(object sender, EventArgs e)
            {
                //Check if put any number in the text
                if (String.IsNullOrEmpty(textDisplay.Text)) return;
                //If is put something...
                //Save the number
                if(!int.TryParse(textDisplay.Text, out num1)) return;
                //Catch the operation if is a number and not empty
                operation = ((Button)sender).Text;
                //Clean the screen
                textDisplay.Clear();
            }
    }
}
