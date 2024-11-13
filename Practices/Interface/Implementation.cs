namespace Practices.Interface
{
    public class Implementation : ICalculate
    {
        public int AddTwoNum(int value1, int value2)
        {
            var result = value1 + value2;
            return result;


            // int i = 12
            // var age = 19;
        }

        public double Calculate(double x, double y)
        {
            var result = x + y;
            return result;
        }
    }
}
