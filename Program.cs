using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [,] marks= new int[4, 3];
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Student {i+1}\'s Roll number");
                marks[i, 0] = int.Parse(Console.ReadLine());
                for(int j = 1; j < 3; j++)
                {
                    Console.WriteLine($"Enter marks of the Student\'s{i + 1} in Sem {j}");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Marks List as follows");
            Console.WriteLine("RollNo \t SemOne \t SemTwo");
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(marks[i, j] + " \t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
