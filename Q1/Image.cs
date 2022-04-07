using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Image
    {
        public string Getstar()
        {
            return "*";
        }
        public void PrintImage(int count,string star)
        {
            int i, j, k, z;
            count = count - 2;
            for (i = 0; i <= count; i++)
            {
                for (j = count; j >= 0; j--)
                {
                    if (i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(star);
                    }
                }
                for (k = 0; k < i; k++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            for (i = 1; i <= 2; i++)
            {
                for (z = 0; z < count; z++)
                {
                    Console.Write(" ");
                }
                count--;
                if (i == 1)
                {
                    Console.WriteLine(star);
                }
                else
                {
                    Console.WriteLine("***");
                }

            }
            Console.Read();
        }
    }
}
