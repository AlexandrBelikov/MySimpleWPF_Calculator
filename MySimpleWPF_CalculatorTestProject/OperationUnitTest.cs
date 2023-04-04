using MySimpleWPF_Calculator;

namespace MySimpleWPF_CalculatorTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Description("Test sum1")]
        public void Sum_two_operand()
        {
            Calculator calculator = new Calculator();
            double op1 = 65;
            double op2 = 35;
            double expect = 100;
            double res = calculator.Plus(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test sum2")]
        public void Sum_two_operand_with_negative_value()
        {
            Calculator calculator = new Calculator();
            double op1 = 65;
            double op2 = -35;
            double expect = 30;
            double res = calculator.Plus(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test minus1")]
        public void Minus_two_operand()
        {
            Calculator calculator = new Calculator();
            double op1 = 65;
            double op2 = 35;
            double expect = 30;
            double res = calculator.Minus(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test minus2")]
        public void Minus_two_operand_with_negative_value()
        {
            Calculator calculator = new Calculator();
            double op1 = 65;
            double op2 = -35;
            double expect = 100;
            double res = calculator.Minus(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test multipy")]
        public void Mult_two_operand()
        {
            Calculator calculator = new Calculator();
            double op1 = 5;
            double op2 = 6;
            double expect = 30;
            double res = calculator.Multipy(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test divide")]
        public void Divide_two_operand()
        {
            Calculator calculator = new Calculator();

            double op1 = 24;
            double op2 = 2;
            double expect = 12;
            double res = calculator.Divide(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test division zero")]
        public void Division_by_zero()
        {
            Calculator calculator = new Calculator();

            double op1 = 65;
            double op2 = 0;
            //double expect = Double.PositiveInfinity;
            double expect = Double.NegativeZero;
            double res = calculator.Divide(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }
    }
}