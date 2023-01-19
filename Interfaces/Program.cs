using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer wr = new Writer();
            ((IWriter) wr).Write("Запущен интерфейс IWrite явным методом.");
        }
    }

    public class Writer : IWriter
    {
       public void Write(string message)
       {
            Console.WriteLine($"{message}");
       }
    }

    public interface IWriter
    {
        void Write(string message);
    }

}
