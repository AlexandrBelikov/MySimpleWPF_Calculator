using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleWPF_Calculator
{
    interface IDefaultOperation
    {
        double Plus(double operandOne, double operandTwo);

        double Minus(double operandOne, double operandTwo);

        double Multipy(double operandOne, double operandTwo);

        double Divide(double operandOne, double operandTwo);


    }
}
