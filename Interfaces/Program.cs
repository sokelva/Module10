﻿using System;
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
        void IReader.Read()
        {
            Console.WriteLine("Читаем файл...");
        }

        void IMailer.SendEmail(string message)
        {
            Console.WriteLine($"Отсылаем письмо по почте...");
        }

        void IWriter.Write()
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

    //======================================================================

    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }

    public class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
