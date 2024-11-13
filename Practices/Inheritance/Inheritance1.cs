namespace Practices.Inheritance
{
    public class Inheritance1 : Inheritance2
    {
        private const string MyName = "Manoj Pant";
        public static async void Main(string[] args)
        {
            Inheritance2 a = new Inheritance2();

            a.AddTwoNumWithParameter(12, 23);
            a.AddTwoNumber();
        }

       
    }
}
