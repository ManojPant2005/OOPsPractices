using Practices.Abstraction;
using Practices.Basics;
using Practices.Inheritance;
using Practices.Interface;
using Practices.Polymorphism;
using System.Runtime.InteropServices;


namespace Practices
{
    public class Program 
    {
        private readonly ICalculate _calculate;

        public Program(ICalculate calculate)
        {
            _calculate = calculate;
        }
       
        public static void Main(string[] args)
        {

            bool myName = true;

            var id = Guid.NewGuid();
            Console.WriteLine(id.ToString());
           
           // Inheritance2 i = new Inheritance2();
           // i.AddTwoNumWithParameter(1, 2);

            string[] Names = ["Manoj Pant", "Suraj Chand", "Deepak Kalouni"];
            Console.WriteLine(Names[2]);
            Calculate calculator = new Calculate();

            // Using different overloaded methods
            Console.WriteLine(calculator.Add(5, 10));        // Calls first method (int, int)
            Console.WriteLine(calculator.Add(5.5, 2.3));    // Calls second method (double, double)
            Console.WriteLine(calculator.Add(1, 2, 3));     // Calls third method (int, int, int)
            Print();

            Animal myAnimal = new Animal();
            Animal myDog = new Dog();  // Polymorphism: Animal reference, but Dog object
            Animal myCat = new Cat();  // Polymorphism: Animal reference, but Cat object

            myAnimal.MakeSound();  // Output: The animal makes a sound.
            myDog.MakeSound();     // Output: The dog barks.
            myCat.MakeSound();
            Print();


            MyClass my = new MyClass();
            my.Id = 101;
            my.Name = "UserName";
            my.Description = "This is description";

            Console.WriteLine(my.Id);
            Console.WriteLine(my.Name);
            Console.WriteLine(my.Description);
        }

        public static void Print()
        {
            Console.WriteLine("Heloo");
        }
                
        
       
    }
}
