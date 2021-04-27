using System.IO;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Parametrs parametrs = new Parametrs();
            string path = @"D:\Андреева\Университет\text.txt";
            string path1 = @"D:\Андреева\Университет\text1.txt";
            char[] array = new char[104857600];
            parametrs.array = array;
            parametrs.path = path1;
            StreamReader sr = new StreamReader(path, false);
            FileInfo file = new FileInfo(path);
            for(int i = 0; i <= file.Length; i+= 104857600)
            {
                sr.Read(array, 0, array.Length);
                parametrs.array = array;
                parametrs.path = path1;
                Parallel.ForEach<object>(new List<object> {parametrs}, Write);
                Console.WriteLine("Цикл");
            }
            Console.ReadLine();
        }
        static void Write(object o)
        {
            Parametrs parametrs = (Parametrs)o;
            try
            {
                using (StreamWriter sw = new StreamWriter(parametrs.path, false, System.Text.Encoding.Default))
                {
                    sw.Write(parametrs.array, 0, parametrs.array.Length);
                    Console.WriteLine("Запись");
                    Thread.Sleep(1000);
                    Console.WriteLine("Запись");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Parametrs
    {
        public string path;
        public char[] array;
    }
}