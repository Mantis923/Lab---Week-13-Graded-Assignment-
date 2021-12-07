using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Week_13_Graded_Assignment_
{
    	
    /// File Name: Homework - Lab - Week 13(Graded Assignment)
    /// Student: Samuel Peppetta
    /// Miracosta college fall 2021
    /// Professor Mark Akola

    class Program
    {
        //  Test programs created to use optional parameters, named parameter and variable number of parameters.
        static void Main(string[] args)
        {

            Console.WriteLine(Average(2, 3));
            Console.WriteLine(Average(2, 6, 8));
            Console.WriteLine(Average(2, 6, 8, 10, -17, 21));
            Console.WriteLine("");
            Console.WriteLine(Increment(1));
            Console.WriteLine(Increment(1, 5));
            Console.WriteLine(Increment(dx: 1,x: 5));

            Console.WriteLine();

             Console.ReadLine();

        }
        public static double Average(params int[] numbers)
        {

            double total = 0;

            foreach (int number in numbers)
            {
                total += number;
                
            }
            return total / numbers.Length;
        }
        public static int Increment(int x, int dx = 1)
        {
            return x + dx; 

        }
    }
}
