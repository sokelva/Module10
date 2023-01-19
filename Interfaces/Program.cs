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
          
        }
         
    }

    class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {
            Console.WriteLine("Читаем файл...");
        }

        public void SendEmail(string message)
        {
            Console.WriteLine($"Отсылаем письмо по почте...");
        }

        public void Write()
        {
            Console.WriteLine("Пишем в файл...");
        }
    }


    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail(string messge);
    }
}
