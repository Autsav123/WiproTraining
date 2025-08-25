using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCommandApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            
           
                
            Console.WriteLine("Even numbers are:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            var numbers1 = new[] { 1, 2, 3 };
            var squaredNumbers = numbers1.Select(n => n * n);
            foreach (var num in squaredNumbers)
            {
                Console.WriteLine(num);
            }

            var words = new[] { "hello", "world" };
            var characters = words.SelectMany(w => w.ToCharArray());
            foreach (var word in characters)
            {
                Console.Write(word + " ");

            }
            Console.WriteLine();

            var numbers2 = new[] { 5, 1, 4, 2 };
            var sortedNumbers = numbers2.OrderBy(n => n);
            foreach(var num in sortedNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
