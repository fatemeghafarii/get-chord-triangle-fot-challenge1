using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter side A:");
            int sideA =Convert.ToInt32(Console.ReadLine());
            double  resultA = Math.Pow(sideA, 2);
            Console.WriteLine("Enter side B:");
            int sideB =Convert.ToInt32(Console.ReadLine());
            double  resultB = Math.Pow(sideB, 2);
            int resultFinal = (int) Math.Sqrt(resultA + resultB);
            System.Console.WriteLine("The result is: " + resultFinal); 
        }         
    }
}

