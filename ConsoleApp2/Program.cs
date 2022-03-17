using ConsoleApp2.Models;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Menu ---------");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");

            string choice = Console.ReadLine();

            
            switch (choice)
            {
                case "1":                    
                    Square square = new Square(10);                    
                    square.CalcArea();
                    //Console.WriteLine(square.side);
                    break;
                case "2":
                    Rectangular rectangular = new Rectangular(2, 22);
                    rectangular.CalcArea();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("This is not found");
                    break;
            }

        }
    }
}
