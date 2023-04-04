using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleWPF_Calculator
{
    interface IMathOperation
    {
        double Lg(double operandOne);
        double Ln(double operandOne);
        double Sin(double operandOne);
        double Cos(double operandOne);
        double Tan(double operandOne);
        double SqrtN(double operandOne);
        double Degere(double operandOne, int operandTwo);
        double Factorial(int operandOne);

        double PowerTwo(double operand);
        double PowerN(double operand,int operandTwo);
    }
}
