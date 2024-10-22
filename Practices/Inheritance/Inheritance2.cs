using Practices.Abstraction;

namespace Practices.Inheritance
{
    public class Inheritance2 : Main
    {
        public override void AddTwoNumber()
        {
            int i = 19;
            int j = 20;
            int result = i + j;

            Console.WriteLine(result);  
        }

        public override void AddTwoNumWithParameter(int value1, int value2)
        {
            var result = value1 + value2;   
            Console.WriteLine(result);
        }

    }
}
