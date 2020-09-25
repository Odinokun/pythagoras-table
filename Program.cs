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
            Console.WriteLine("Введите целое число - размер таблицы.");
            int tableSize = int.Parse(Console.ReadLine()) + 1; //задаем размер таблицы
            int tableSizeLength = Convert.ToString(tableSize).Length; //длина символа размера страницы
            int maxValueLength = Convert.ToString(tableSize * tableSize).Length; //длина максимального значения таблицы

            Console.WriteLine("\n\n");

            //begin верхняя строка таблицы
            int firstLine = 0;
            while (firstLine < tableSize)
            {
                if (firstLine == 0) //первая ячейка
                {
                    Console.Write(" ");

                    int tdWidth = tableSizeLength - Convert.ToString(firstLine).Length; //разница в ширине

                    while (tdWidth > 0) //корректируем ширину ячейки
                    {
                        Console.Write(" ");
                        tdWidth--;
                    }

                    Console.Write(" | ");
                }
                else //основные ячейки
                {
                    Console.Write(firstLine + " ");

                    int tdWidth = maxValueLength - Convert.ToString(firstLine).Length; //разница в ширине

                    while (tdWidth > 0) //корректируем ширину ячейки
                    {
                        Console.Write(" ");
                        tdWidth--;
                    }
                }
                firstLine++;
            }
            Console.Write("\n");
            //end верхняя строка таблицы

            //begin разделитель под верхней строкой в таблице
            int separator = 0;
            while (separator < tableSize)
            {
                if (separator == 0) //первая ячейка
                {
                    Console.Write("-");
                    int tdWidth = tableSizeLength - Convert.ToString(separator).Length; //разница в ширине

                    while (tdWidth > 0) //корректируем ширину ячейки
                    {
                        Console.Write("-");
                        tdWidth--;
                    }
                    Console.Write("-+");
                }
                else //основные ячейки
                {
                    Console.Write("-");

                    int tdWidth = maxValueLength; //максимальная ширина ячейки

                    while (tdWidth > 0) //корректируем ширину ячейки
                    {
                        Console.Write("-");
                        tdWidth--;
                    }
                }

                separator++;
            }
            Console.Write("\n");
            //end разделитель под верхней строкой в таблице

            //begin основные строки
            int vertical = 1;

            while (vertical < tableSize)
            {
                //первая ячейка
                Console.Write(vertical);
                int tdWidth = tableSizeLength - Convert.ToString(vertical).Length; //разница в ширине

                while (tdWidth > 0) //корректируем ширину ячейки
                {
                    Console.Write(" ");
                    tdWidth--;
                }
                Console.Write(" | ");

                int mult = 1; //множитель

                while (mult < tableSize)
                {

                    Console.Write(mult * vertical + " "); //результат умножения
                    int tdWidthMain = maxValueLength - Convert.ToString(mult * vertical).Length; //разница в ширине

                    while (tdWidthMain > 0) //корректируем ширину ячейки
                    {
                        Console.Write(" ");
                        tdWidthMain--;
                    }
                    mult++;
                }

                vertical++;

                Console.Write("\n");
            }
            //end основные строки

            Console.WriteLine("\n\n");
        }
    }
}