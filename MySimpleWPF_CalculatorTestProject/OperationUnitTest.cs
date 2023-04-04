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
            double expect = Double.NegativeZero;
            double res = calculator.Divide(op1, op2);
            Assert.That(res, Is.EqualTo(expect));
        }
        [Test, Description("Test Sin")]
        public void Sin_Check()
        {
            Calculator calculator = new Calculator();

            double op1 = Math.PI / 2;
            double expect = 1;
            double res = calculator.Sin(op1);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test Cos")]
        public void Cos_Check()
        {
            Calculator calculator = new Calculator();

            double op1 = 0;
            double expect = 1;
            double res = calculator.Cos(op1);
            Assert.That(res, Is.EqualTo(expect));
        }

        [Test, Description("Test Tan")]
        public void Tan_Check()
        {
            Calculator calculator = new Calculator();

            double op1 = 0;
            double expect = 0;
            double res = calculator.Tan(op1);
            Assert.That(res, Is.EqualTo(expect));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]
        [Test, Description("Test Ln")]
        public void Ln_Check(double x)
        {
            Calculator calculator = new Calculator();
            double expected = Math.Log(x);
            double actual = calculator.Ln(x);
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }


        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]
        [Test, Description("Test Log")]
        public void Log_Check(double x)
        {
            Calculator calculator = new Calculator();
            double expected = Math.Log10(x);
            double actual = calculator.Lg(x);
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }


        public double Factorial(int operandOne)
        {

            if (operandOne == 1) return 1;

            return operandOne * Factorial(operandOne - 1);

        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(25)]
        [TestCase(50)]
        [Test, Description("Test Factorial")]
        public void Factorial_Check(int x)
        {
            Calculator calculator = new Calculator();
            double expected = Factorial(x);
            double actual = calculator.Factorial(x);
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }
    }
}