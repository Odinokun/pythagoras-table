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
                    Console.Write("  |");//first td
                }
                else if (firstLine == 9)
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
            while (separator < 10)
            {
                if (separator == 0)
                {
                    Console.Write("--+");//first td
                }
                else if (separator == 9)
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

            while (vertical < 10)
            {

                Console.Write(vertical + " |");//first td

                int mult = 1;

                while (mult < 10)
                {
                    if (mult == 9)
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
