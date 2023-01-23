using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Interfaces
{
    class Program
    {
        static ILogger logger { get; set; }

        static void Main(string[] args)
        {
            do
            {
                Calculate clkl = new Calculate();
                try
                {
                    clkl.Event();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите число а");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число b");
                    int b = int.Parse(Console.ReadLine());
                    clkl.DoCalculate(a, b);
                }
                catch(Exception ex)
                {
                    clkl.Error(ex.Message);
                }
                finally
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("---------------------------------------\nКалькулятор закончил вычисления.");
                    Console.ReadKey();
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }

    public class Calculate : ILogger, IDoCalculate
    {
        public Calculate()
        {
        }

        public void DoCalculate(int a, int b)
        {
            Console.WriteLine($"Результат: {a}+{b} = {a + b}");
            Thread.Sleep(2000);
        }

        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Сообщение об ошибке: {message}.");
            Thread.Sleep(2000);
        }

        public void Event()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Запущен калькулятор.\n----------------------------------------------------");
            Thread.Sleep(3000);
        }
    }

    public interface ILogger
    {
        void Error(string mess);

        void Event();
    }

    public interface IDoCalculate
    {
        void DoCalculate(int a, int b);
    }
}
