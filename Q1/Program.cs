using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new Image();
            var star = image.Getstar();
            Console.Write("Input :Number more than 4 ");
            var input = Console.ReadLine();
            int count = Convert.ToInt32(input);
            Console.WriteLine("Output:");
            Console.WriteLine();
            image.PrintImage(count, star);
        }
    }
}
