using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("Enter your score");
            score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80 & score <= 89)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70 & score <= 79)
            {
                Console.WriteLine("Grade: C");
            }
            else if (score >= 60 & score <= 69)
            {
                Console.WriteLine("Grade: D");
            }
            else if (score < 60)
            {
                Console.WriteLine("Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
