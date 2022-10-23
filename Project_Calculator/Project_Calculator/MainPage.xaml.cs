using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_Calculator
{
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string mathOp;
        double firstNum, secondNum;

        public MainPage()
        {
            InitializeComponent();
            Clear(this, null);
        }
		void OnSelectNum(object sender, EventArgs e) //this method is called when a number button is pressed
		{
			Button button = (Button)sender;
			string pressed = button.Text;

			if (this.resultText.Text == "0" || currentState < 0)
			{
				this.resultText.Text = "";
				if (currentState < 0)
					currentState *= -1;
			}

			this.resultText.Text += pressed;

		double number;
			if (double.TryParse(this.resultText.Text, out number))
			{
				this.resultText.Text = number.ToString("N0");
				if (currentState == 1)
				{
					firstNum = number;
				}
				else
				{
					secondNum = number;
				}

				
			}
			this.formulaText.Text = number.ToString(firstNum + mathOp + secondNum);
		}

		void OnSelectOp(object sender, EventArgs e) //this method is called when an operator button is pressed
		{
			currentState = -2;
			Button button = (Button)sender;
			string pressed = button.Text;
			mathOp = pressed;
		}

		void Clear(object sender, EventArgs e) //this method is called when C button is pressed
		{
			firstNum = 0;
			secondNum = 0;
			currentState = 1;
			this.resultText.Text = "0";
			this.formulaText.Text = "0";
		}

		void Percentage(object sender, EventArgs e) //this method is called when percentage button is pressed
		{
			if (currentState == -1 || currentState == 1)
			{
				var result = firstNum / 100;
				this.resultText.Text = result.ToString();
				firstNum = result;
				currentState = -1;
			}
		}

		void Plus_Minus(object sender, EventArgs e) //this method is called when +/- button is pressed
		{
			if (currentState == -1 || currentState == 1)
			{
				var result = firstNum / 100;
				this.resultText.Text = result.ToString();
				firstNum = result;
				currentState = -1;
			}
		}

		void Calculate(object sender, EventArgs e) //this method is called when equals to button is pressed
		{
			if (currentState == 2)
			{
				var result = Calculator_Op.Calculate(firstNum, secondNum, mathOp);

				this.resultText.Text = result.ToString();
				firstNum = result;
				currentState = -1;
			}
		}
		

	}

}
