using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    switch (i % 2)
                    {
                        case 0:
                            if (j % 2 != 0)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("O");
                            }
                            break;
                        default:
                            if (j % 2 == 0)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("O");
                            }
                            break;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}