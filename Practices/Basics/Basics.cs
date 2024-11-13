namespace Practices.Basics
{
    public class Basics
    {
        public static void Main(string[] args)
        {

            var myName = "Manoj";
            var _age = 12;
            Console.WriteLine(_age.ToString());
            Console.WriteLine(myName);


            int myAge = 12;
            double updatedAge = myAge;

            //var IfDatabaseExistOrNot;

            Console.WriteLine(updatedAge.ToString());

           
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int

            MyMethod(UserName : "Deepak");
            AnotherMethod("MyUserName");

            var NewName = "12";
            string NewNameAgain = "324";


        }

        public static void MyMethod(string UserName = "Manoj")
        {
            Console.WriteLine(UserName);
        }

        public static void AnotherMethod(string UserName)
        {
            Console.WriteLine(UserName);
        }
    }
}
