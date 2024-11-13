namespace Practices.Programs
{
    public class AddTwoNumber
    {
        public void Main()
        {
            AddTwoNum();
            AddTwoNumberWithParameter(20, 56);

            ForLoop();  
            ForeachLoop();  
        }

        // #1
        private void AddTwoNum()
        {
            int value1 = 24;
            int value2 = 46;
            int result = value1 + value2;   
            Console.WriteLine(result);      
        }

        // #2

        private static void AddTwoNumberWithParameter(int value1, int value2)
        {
            var result = value1 + value2;   
            Console.WriteLine(result);  
        }

        // #3

        private static void SimpleCalculation()
        {
            int x = 5;
            int y = 6;
            int sum = x + y;
            Console.WriteLine(sum); //sum of x + y
        }

        private static void ForLoop()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

       
        public void ForeachLoop()
        {
            string[] collection = ["Manoj", "Deepak", "Mohit", "Rohan", "Ramesh"];
            foreach (var item in collection)
            {
                Console.WriteLine(item.FirstOrDefault());    
            }
        }

       
        //Access modifier : private 

        //Operators : Airthmatic(+ - * %)  ! ? && == = || != 


        //Polymorphism : Method overloading | Overriding


    }
}

