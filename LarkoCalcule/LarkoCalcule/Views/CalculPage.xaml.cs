using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LarkoCalcule.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculPage : ContentPage
	{
        int currentState = 1;
        string mathOperator;
        double firstNumber, secondNumber;

        public CalculPage ()
		{
			InitializeComponent ();
            btnCancelClicked(this, null);


        }
        private void btnChiffreClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (this.txtResultat.Text == "0" || currentState < 0)
            {
                this.txtResultat.Text = "";
                if (currentState < 0)
                    currentState *= -1;
            }

            this.txtResultat.Text += pressed;

            double number;
            if (double.TryParse(this.txtResultat.Text, out number))
            {
                this.txtResultat.Text = number.ToString("N0");
                if (currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }

        private void DivideButtonClicked(object sender, EventArgs e)
        {
            currentState = -2;
            ImageButton button = (ImageButton)sender;
            string pressed = "÷";
            mathOperator = pressed;
        }

        private void MultiplyButtonClicked(object sender, EventArgs e)
        {
            currentState = -2;
            ImageButton button = (ImageButton)sender;
            string pressed = "*";
            mathOperator = pressed;
        }
        private void SubtractButtonClicked(object sender, EventArgs e)
        {
            currentState = -2;
            ImageButton button = (ImageButton)sender;
            string pressed = "-";
            mathOperator = pressed;
        }
        private void AddButtonClicked(object sender, EventArgs e)
        {
            currentState = -2;
            ImageButton button = (ImageButton)sender;
            string pressed = "+";
            mathOperator = pressed;
        }
        private void EqualButtonClicked(object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                var result = SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

                this.txtResultat.Text = result.ToString();
                firstNumber = result;
                currentState = -1;
            }
        }

        void btnCancelClicked(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentState = 1;
            this.txtResultat.Text = "0";
        }
    }
}