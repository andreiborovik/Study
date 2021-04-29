using System.IO;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Parametrs parametrs = new Parametrs();
            char[] array = new char[104857600];
            var mainPath = Path.GetFullPath(@"..\..\..\");
            Console.WriteLine(mainPath);
            List<string> paths = CreateFile(mainPath);
            WriteRandomData(paths[0]);
            List<object> list = new List<object>();
            using (StreamReader sr = new StreamReader(mainPath + "text.txt", false))
            {
                FileInfo file = new FileInfo(mainPath + "text.txt");
                for (int i = 0; i <= file.Length; i += 104857600)
                {
                    sr.Read(array, 0, array.Length);
                    for (int j = 1; j < paths.Count; j++)
                    {
                        list.Add(new Parametrs() { array = array, path = paths[j] });
                    }
                    Console.WriteLine("Цикл");

                    Parallel.ForEach<object>(list, Write);
                }
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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void WriteRandomData(string path)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                do
                {
                    int random_value = random.Next(0, letters.Length - 1);
                    sw.Write(letters[random_value]);
                } while (path.Length < 1 * 1024 * 1024 * 1024);
            }
        }

        static List<string> CreateFile(string path)
        {
            List<string> paths = new();
            for (int i = 0; i < 11; i++)
            {
                string newPath = path + "text" + i + ".txt";
                var file = File.Create(newPath);
                paths.Add(newPath);
            }
            return paths;
        }
    }
    class Parametrs
    {
        public string path { get; set; }
        public char[] array { get; set; }
    }
}