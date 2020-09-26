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
            Console.WriteLine("Введите первое число по горизонтали:");
            int firstNumberHorisont = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число по горизонтали:");
            int secondNumberHorisont = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число по вертикали:");
            int firstNumberVert = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число по вертикали:");
            int secondNumberVert = int.Parse(Console.ReadLine());

            int tableSizeVertLength = Convert.ToString(secondNumberVert).Length; //длина max вертикального символа размера страницы
            int maxValueLength = Convert.ToString(secondNumberHorisont * secondNumberVert).Length; //длина максимального значения таблицы

            Console.WriteLine("");

            //BEGIN верхняя строка таблицы

            int firstTdWidth = tableSizeVertLength; //ширина первой ячейки
            while (firstTdWidth > 0) //корректируем ширину ячейки
            {
                Console.Write(" ");
                firstTdWidth--;
            }
            Console.Write(" | ");

            int firstLine = firstNumberHorisont;
            while (firstLine <= secondNumberHorisont) //основные ячейки
            {
                Console.Write(firstLine + " ");

                int tdWidth = maxValueLength - Convert.ToString(firstLine).Length; //разница в ширине

                while (tdWidth > 0) //корректируем ширину ячейки
                {
                    Console.Write(" ");
                    tdWidth--;
                }
                firstLine++;
            }
            Console.Write("\n");
            //END верхняя строка таблицы


            //BEGIN разделитель под верхней строкой в таблице

            Console.Write("-"); //первая ячейка

            firstTdWidth = tableSizeVertLength - 1; //разница в ширине

            while (firstTdWidth > 0) //корректируем ширину ячейки
            {
                Console.Write("-");
                firstTdWidth--;
            }
            Console.Write("-+");

            int separator = firstNumberHorisont;
            while (separator <= secondNumberHorisont) //основные ячейки
            {
                Console.Write("-");

                int tdWidth = maxValueLength; //максимальная ширина ячейки

                while (tdWidth > 0) //корректируем ширину ячейки
                {
                    Console.Write("-");
                    tdWidth--;
                }

                separator++;
            }
            Console.Write("\n");
            //END разделитель под верхней строкой в таблице


            //BEGIN основные строки

            int vertical = firstNumberVert;

            while (vertical <= secondNumberVert)
            {
                //первая ячейка
                Console.Write(vertical);
                int tdWidth = tableSizeVertLength - Convert.ToString(vertical).Length; //разница в ширине

                while (tdWidth > 0) //корректируем ширину ячейки
                {
                    Console.Write(" ");
                    tdWidth--;
                }
                Console.Write(" | ");

                int mult = firstNumberHorisont; //множитель

                while (mult <= secondNumberHorisont) //основные ячейки
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
            //END основные строки

            Console.WriteLine("\n\n");
        }
    }
}