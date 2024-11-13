using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Basics
{
    internal class CodeLogics
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddTwoNumber(int value1, int value2)
        {
            var result = value1 + value2;
            Console.WriteLine(result);     
        }
    }
}
