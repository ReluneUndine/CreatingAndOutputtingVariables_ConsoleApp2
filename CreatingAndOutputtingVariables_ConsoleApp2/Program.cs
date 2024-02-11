using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndOutputtingVariables_ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args) /// Точка входа, начало кода

        {/// Вариант 2. Задание то же, но здесь я использую паттерн и escape последовательность.
         /// Паттерн нужен для того, чтобы не писать Console.WriteLine много раз. А escape последовательность - чтобы каждая новая переменная шла с новой строки.

            string fullName = "Петров Петр Петрович";
            byte age = 17;
            string email = "PetrPetrov@gmail.com";
            double programmingGrades = 4.75;
            uint mathGrades = 5;
            double physicsGrades = 4.25;

            string pattern = "Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              programmingGrades,
                              mathGrades,
                              physicsGrades);
            Console.ReadKey();
        }
    }
}
