using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4BulahovVasilyev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая операция вам нужна, введите цифру?" + Environment.NewLine + "1. Сложение " + Environment.NewLine + "2. Вычитание " + Environment.NewLine + "3. Умножение " + Environment.NewLine + "4. Деление ");
            string k = Console.ReadLine();
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
        }
    }
}
