using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //begin first line
            int firstLine = 0;
            while (firstLine < 10)
            {
                if (firstLine == 0)
                {
                    Console.Write("  |");
                }
                else if (firstLine == 9)
                {
                    Console.Write(" " + firstLine + "\n");
                }
                else
                {
                    Console.Write(" " + firstLine + " ");
                }

                firstLine++;
            }
            //end first line

            //begin separator line
            int separator = 0;
            while (separator < 10)
            {
                if (separator == 0)
                {
                    Console.Write("--+");
                }
                else if (separator == 9)
                {
                    Console.Write("---\n");
                }
                else
                {
                    Console.Write("---");
                }

                separator++;
            }
            //end separator line

            //begin vertical line
            int vertical = 0;

            while (vertical < 10)
            {

                Console.Write(vertical + " |");

                int mult = 1;

                while (mult < 10)
                {
                    if (mult == 9)
                    {
                        Console.Write(" " + mult * vertical + "\n");
                    }
                    else
                    {
                        if (mult * vertical < 10)
                        {
                            Console.Write(" " + mult * vertical + " ");

                        }
                        else
                        {
                            Console.Write(" " + mult * vertical);

                        }
                    }
                    mult++;
                }

                vertical++;
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
