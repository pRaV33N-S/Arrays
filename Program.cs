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
            /*
            int [,] marks= new int[4, 5];
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Student {i+1}\'s Roll number");
                marks[i, 0] = int.Parse(Console.ReadLine());
                for(int j = 1; j < 5; j++)
                {
                    Console.WriteLine($"Enter marks of the Student\'s{i + 1} in Sem {j}");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Marks List as follows");
            Console.WriteLine("RollNo SemOne SemTwo SemThree SemFour Total");
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                { 
                    Console.Write(marks[i, j] + " \t");
                }
                int total = 0;
                for (int k = 1; k < 5; k++)
                {
                    total = total + marks[i, k];
                }
                Console.Write(total);
                Console.WriteLine("");
            }*/
              

                int[][] employee = new int[5][];
                employee[0] = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter the num of columns");
                    int temp = int.Parse(Console.ReadLine());
                    employee[i] = new int[temp];
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < employee[i].Length; j++)
                    {
                        Console.WriteLine($"Enter the Salary for Day{j + 1}");
                        employee[i][j] = int.Parse(Console.ReadLine());
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    int total = 0;
                    for (int j = 0; j < employee[i].Length; j++)
                    {
                        Console.Write(employee[i][j] + "\t");
                        total = total + employee[i][j];
                    }
                    Console.Write(total);
                    Console.WriteLine();
                }
            }
        }

    }
}
}
