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
            Console.WriteLine("Введите целое число для задавания размера таблицы.");
            int tableSize = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine("\n\n");

            //begin first line
            int firstLine = 0;
            while (firstLine < tableSize)
            {
                if (firstLine == 0)
                {
                    Console.Write("  |");//first td
                }
                else if (firstLine == tableSize - 1)
                {
                    Console.Write(" " + firstLine + "\n");//last td
                }
                else
                {
                    Console.Write(" " + firstLine + " ");//main td
                }

                firstLine++;
            }
            //end first line

            //begin separator line
            int separator = 0;
            while (separator < tableSize)
            {
                if (separator == 0)
                {
                    Console.Write("--+");//first td
                }
                else if (separator == tableSize - 1)
                {
                    Console.Write("---\n");//last td
                }
                else
                {
                    Console.Write("---");//main td
                }

                separator++;
            }
            //end separator line

            //begin vertical line
            int vertical = 1;

            while (vertical < tableSize)
            {
                //first td
                if (vertical < 10)
                {
                    Console.Write(vertical + " |");
                }
                else
                {
                    Console.Write(vertical + "|");
                }

                int mult = 1;

                while (mult < tableSize)
                {
                    if (mult == tableSize - 1)
                    {
                        Console.Write(" " + mult * vertical + "\n");//last td
                    }
                    else
                    {   //main td
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

            Console.WriteLine("\n\n");
        }
    }
}
