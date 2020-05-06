using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Question3LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() 
            { 55, 200, 740, 76, 230, 482, 95 };

            var answer = arr.Where(n => (n > 80));

            Console.WriteLine("The numbers greater than 80 are:");

            foreach (var n in answer)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
