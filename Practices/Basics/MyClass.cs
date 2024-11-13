namespace Practices.Basics
{
    public class MyClass
    {
        public MyClass()
        {

        }
        public static void Main(string[] args)
        {
        }
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int AadharNo { get; set; }   


        private void SayHiToEveryone()
        {
            Console.WriteLine("This is new method for saying Hie");
            SayHello();
        }
        public void SayHello()
        {
            Console.WriteLine("Hello User");
        }
    }
}
