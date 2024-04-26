using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void table4(int number)
            {
                for (int i = 1; i <= number; i++)
                {
                    bool flag = true;
                    for (int j = 1; j <= number; j++)
                    {

                        if (i > 1 && flag == true)
                        {
                            Console.Write("{0,4}", i);
                            flag = false;
                        }
                        if (i == 1 && j == 1)
                        {
                            Console.Write("    ");

                        }
                        Console.Write("{0,4}", j * i);

                    }
                    if (i == 1)
                    {
                        Console.WriteLine();
                        Console.Write("{0,4}", i);

                        for (int j = 1; j <= number; j++)
                        {
                            Console.Write("{0,4}", j * i);

                        }
                    }
                    Console.WriteLine();
                }
            }
            int tableNumber = Int32.Parse(Console.ReadLine());
            table4(tableNumber);
            Console.ReadLine();
        }
    }
}
