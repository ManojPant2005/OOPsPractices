namespace Practices.Polymorphism
{
    public class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
       

        // Second overload method for Add
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Third overload method for Add
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }



    }
}
