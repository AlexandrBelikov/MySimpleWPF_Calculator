using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MySimpleWPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string output = "";
        double tmp = 0;
        string operation = "";
        bool check = false;
        double memoryCellValue = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputOperand(object sender, RoutedEventArgs e)
        {
            string buttonName = ((Button)sender).Name;

            if (output.Length >= 1 && output[0] == '0')
            {
                output += ".";

            }

            switch (buttonName)
            {
                case "numZero":
                    output += "0";
                    outputInfo.Text = output;
                    break;

                case "numOne":
                    output += "1";
                    outputInfo.Text = output;
                    break;

                case "numTwo":
                    output += "2";
                    outputInfo.Text = output;
                    break;

                case "numThree":
                    output += "3";
                    outputInfo.Text = output;
                    break;

                case "numFour":
                    output += "4";
                    outputInfo.Text = output;
                    break;

                case "numFive":
                    output += "5";
                    outputInfo.Text = output;
                    break;

                case "numSix":
                    output += "6";
                    outputInfo.Text = output;
                    break;

                case "numSeven":
                    output += "7";
                    outputInfo.Text = output;
                    break;

                case "numEight":
                    output += "8";
                    outputInfo.Text = output;
                    break;

                case "numNine":
                    output += "9";
                    outputInfo.Text = output;
                    break;

                case "numE":
                    output = "";
                    output += Math.Round(Math.E, 5, MidpointRounding.ToEven).ToString();
                    outputInfo.Text = output;
                    break;

                case "numPi":
                    output = "";
                    output += Math.Round(Math.PI, 5, MidpointRounding.ToEven).ToString();
                    outputInfo.Text = output;
                    break;

                case "dot":
                    if (output.Length == 1)
                    {
                        output += ".";
                        outputInfo.Text = output;
                    }
                    break;
            }
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                tmp = double.Parse(output);

                output = "";

                operation = "+";
            }
            tmpInfo.Text = (tmp.ToString() + " " + operation + " ");

            check = true;
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                tmp = double.Parse(output);

                output = "";

                operation = "-";
            }
            tmpInfo.Text = (tmp.ToString() + " " + operation + " ");

            check = true;
        }

        private void multipyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                tmp = double.Parse(output);

                output = "";

                operation = "x";
            }
            tmpInfo.Text = (tmp.ToString() + " " + operation + " ");

            check = true;
        }

        private void divideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                tmp = double.Parse(output);

                output = "";

                operation = "÷";
            }
            tmpInfo.Text = (tmp.ToString() + " " + operation + " ");

            check = true;
        }

        private void equalBtn_Click(object sender, RoutedEventArgs e)
        {
            if (outputInfo.Text == " ")
                return;


            if (check != false)
            {
                Calculator operation = new Calculator();

                switch (this.operation)
                {
                    case "+":
                        tmpInfo.Text += outputInfo.Text;
                        double outputTempAdd = operation.Plus(tmp, double.Parse(outputInfo.Text));
                        output = outputTempAdd.ToString();
                        outputInfo.Text = output;
                        tmpInfo.Text += " = " + output;
                        break;

                    case "-":
                        tmpInfo.Text += outputInfo.Text;
                        double outputTempMin = operation.Minus(tmp, double.Parse(outputInfo.Text));
                        output = outputTempMin.ToString();
                        outputInfo.Text = output;
                        break;

                    case "x":
                        tmpInfo.Text += outputInfo.Text;
                        double outputTempMul = operation.Multipy(tmp, double.Parse(outputInfo.Text));
                        output = outputTempMul.ToString();
                        outputInfo.Text = output;
                        break;

                    case "÷":
                        tmpInfo.Text += outputInfo.Text;
                        double outputTempDiv = operation.Divide(tmp, double.Parse(outputInfo.Text));
                        output = outputTempDiv.ToString();
                        outputInfo.Text = output;
                        break;
                }

                check = false;
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            outputInfo.Text = "";
            tmpInfo.Text = "";
            output = "";
        }
        private void BackspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (outputInfo.Text.Length > 0)
            {
                outputInfo.Text = outputInfo.Text.Remove(outputInfo.Text.Length - 1);
                output = outputInfo.Text;
            }

        }

        private void factBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "" || output.GetType() == typeof(int))
            {
                Calculator operation = new Calculator();
                res = operation.Factorial(int.Parse(outputInfo.Text));
            }

            tmpInfo.Text = output + "! = " + res.ToString();
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void sinBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "")
            {
                Calculator operation = new Calculator();
                res = Math.Round(operation.Sin(double.Parse(outputInfo.Text)), 5, MidpointRounding.ToEven);
            }
            tmpInfo.Text = "sin(" + output + ") = " + res;
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void cosBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "")
            {
                Calculator operation = new Calculator();
                res = Math.Round(operation.Cos(double.Parse(outputInfo.Text)), 5, MidpointRounding.ToEven);
            }
            tmpInfo.Text = "cos(" + output + ") = " + res;
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void tanBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "")
            {
                Calculator operation = new Calculator();
                res = Math.Round(operation.Tan(double.Parse(outputInfo.Text)), 5, MidpointRounding.ToEven);
            }
            tmpInfo.Text = "tan(" + output + ") = " + res;
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void lnBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "")
            {
                Calculator operation = new Calculator();
                res = Math.Round(operation.Ln(double.Parse(outputInfo.Text)), 5, MidpointRounding.ToEven);
            }
            tmpInfo.Text = "Ln(" + output + ") = " + res;
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void logBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "")
            {
                Calculator operation = new Calculator();
                res = Math.Round(operation.Lg(double.Parse(outputInfo.Text)), 5, MidpointRounding.ToEven);
            }
            tmpInfo.Text = "Log(" + output + ") = " + res;
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void sqrtBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "")
            {
                Calculator operation = new Calculator();
                res = Math.Round(operation.SqrtN(double.Parse(outputInfo.Text)), 5, MidpointRounding.ToEven);
            }
            tmpInfo.Text = "√" + output + " = " + res;
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void powerTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (output != "")
            {
                Calculator operation = new Calculator();
                res = Math.Round(operation.PowerTwo(double.Parse(outputInfo.Text)), 5, MidpointRounding.ToEven);
            }
            tmpInfo.Text = output + "² = " + res;
            output = res.ToString();
            outputInfo.Text = res.ToString();
        }

        private void powerNBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                tmp = double.Parse(output);
                output = "";
                tmpInfo.Text = (tmp.ToString() + "^");
            }

        }

        private void ReversBtn_Click(object sender, RoutedEventArgs e)
        {
            tmp = double.Parse(outputInfo.Text);
            double reversNum = (tmp * (-1));
            output = reversNum.ToString();
            outputInfo.Text = reversNum.ToString();
        }

        private void MC_Click(object sender, RoutedEventArgs e)
        {
            memoryCellValue = 0;
            memoryCell.Text = "Memory cell : " + memoryCellValue.ToString();

        }

        private void MR_Click(object sender, RoutedEventArgs e)
        {
            outputInfo.Text = memoryCellValue.ToString();
        }

        private void Mpl_Click(object sender, RoutedEventArgs e)
        {
            memoryCellValue += double.Parse(outputInfo.Text);
            memoryCell.Text = "Memory cell : " + memoryCellValue.ToString();
        }

        private void Mmin_Click(object sender, RoutedEventArgs e)
        {
            memoryCellValue -= double.Parse(outputInfo.Text);
            memoryCell.Text = "Memory cell : " + memoryCellValue.ToString();
        }

        private void MS_Click(object sender, RoutedEventArgs e)
        {
            memoryCellValue = double.Parse(outputInfo.Text);
            memoryCell.Text = "Memory cell : " + memoryCellValue.ToString();
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {
            if (memoryCell.Visibility == Visibility.Visible)
                memoryCell.Visibility = Visibility.Collapsed;
            else
                memoryCell.Visibility = Visibility.Visible;
        }
    }
}
