using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Calculator
{
    class Calculator_Op
    {
        public static double Calculate(double value1, double value2, string mathOp)
        {

            double result = 0;

            switch (mathOp)
            {
                case "÷":
                    result = value1 / value2;
                    break;
                case "×":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }

            return result;
        }
    }
}
