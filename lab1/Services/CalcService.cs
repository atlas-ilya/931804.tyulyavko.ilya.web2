using System;


namespace lab1.Services
{
    public class CalcService : ICalc
    {
        public int value1 { get; private set; }
        public int value2 { get; private set; }

        public CalcService()
        {
            value1 = new Random().Next(0, 10);
            value2 = new Random().Next(0, 10);

        }

        public int Add()
        {
            return value1 + value2;
        }

        public int Sub()
        {
            return value1 - value2;
        }

        public int Div()
        {
            try
            {
                return value1 / value2;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }

        public int Mult()
        {
            return value1 * value2;
        }

    }
}
