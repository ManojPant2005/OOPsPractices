namespace Practices.Basics
{
    public class MyClass
    {
        public MyClass()
        {

        }
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hello User");
        }
    }
}
