namespace Practices.Basics
{
    public class Functions
    {
        public static void Main(string[] args)
        {
            SayHello();
        }

        private static void SayHello(string Message = "Hello everyone")
        {
            Console.WriteLine(Message); 
        }
    }
}
