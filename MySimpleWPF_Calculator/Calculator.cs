using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleWPF_Calculator
{
        public class Calculator : IDefaultOperation, IMathOperation
        {
            public double Divide(double operandOne, double operandTwo)
            {
                if (operandTwo == 0)
                {
                    return 0;
                }
                return operandOne / operandTwo;
            }

            public double Minus(double operandOne, double operandTwo)
            {
                return operandOne - operandTwo;
            }

            public double Multipy(double operandOne, double operandTwo)
            {
                return operandOne * operandTwo;
            }

            public double Plus(double operandOne, double operandTwo)
            {
                return operandOne + operandTwo;
            }
            public double Cos(double operandOne)
            {
                return Math.Cos(operandOne);
            }

            public double Degere(double operandOne, int operandTwo)
            {
                return Math.Pow(operandOne, operandTwo);
            }

            public double Factorial(int operandOne)
            {
                IEnumerable<int> ints = Enumerable.Range(1, operandOne);
                int factorial = ints.Aggregate((f, s) => f * s);
                return factorial;

            }

            public double Lg(double operandOne)
            {
                return Math.Log10(operandOne);
            }

            public double Ln(double operandOne)
            {
                return Math.Log(operandOne);
            }

            public double Sin(double operandOne)
            {
                return Math.Sin(operandOne);
            }

            public double SqrtN(double operandOne)
            {
                return Math.Sqrt(operandOne);
            }

            public double PowerTwo(double operandOne)
            {
                return Math.Pow(operandOne,2);
            }

            public double PowerN(double operandOne,int operandTwo)
            {
                return Math.Pow(operandOne, operandTwo);
            }

            public double Tan(double operandOne)
            {
                return Math.Tan(operandOne);
            }

        }
    }

