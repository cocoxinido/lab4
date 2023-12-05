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
            Console.WriteLine("Введите цифру действия..." + Environment.NewLine + "1) Сложение " + Environment.NewLine + "2) Вычитание " + Environment.NewLine + "3) Умножение " + Environment.NewLine + "4) Деление ");
            string k = Console.ReadLine();
            Console.WriteLine("Введите 1-ое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число:");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (k)
            {
                case "1":
                    plus(a, b);
                    break;
                case "2":
                    minus(a, b);
                    break;
                case "3":
                    umnog(a, b);
                    break;
                case "4":
                    if (b != 0)
                    {
                        del(a, b);
                    }
                    else
                    {
                        Console.WriteLine("Результат операции: деление на ноль невозможно.");
                    }
                    break;
                default:
                    Console.WriteLine(" Результат операции: некорректный выбор операции.");
                    break;
            }

        }

    }
}
