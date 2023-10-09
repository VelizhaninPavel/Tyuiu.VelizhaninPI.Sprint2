using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint2.Task3.V10.Lib;
using Tyuiu.VelizhaninPI.Sprint2.Task3.V10.Test;

namespace Tyuiu.VelizhaninPI.Sprint2.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
            Console.WriteLine("* значение  переменной X с клавиатуры. Округлить полученное значение      *");
            Console.WriteLine("* до трех знаков после запятой                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("  ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Значение Y = {res}");
            Console.ReadLine();
        }
    }
}
