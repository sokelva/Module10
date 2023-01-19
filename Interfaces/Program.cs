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

        public 
    }

    public class Writer :IWriter, IWorker
    {
       public void Write(string message)
       {
            Console.WriteLine($"{message}");
       }

        public void Build()
        {

        }
    }

    public interface IWriter
    {
        void Write(string message);
    }

    public interface IWorker
    {
        void Build();
    }

}
