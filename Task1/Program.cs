using System.IO;
using System;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main()
        {
            string path = @"D:\Андреева\Университет\text.txt";
            string path1 = @"D:\Андреева\Университет\text1.txt";
            char[] array = new char[209715200];
            FileInfo file = new FileInfo(path);
            ReadWriteDataAsync(path, path1, array, file);
            Console.Read();            
        }

        static async void ReadWriteDataAsync(string path, string path1, char[] array, FileInfo file)
        {
            long size;
            await Task.Run(() => Console.WriteLine("Начало работы"));
            try
            {
                using (StreamWriter sw = new StreamWriter(path1, false))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        for (int i = 0; i <= file.Length; i += array.Length)
                        {
                            if (file.Length - i > array.Length) size = array.Length;
                            else size = file.Length - i;
                            await sr.ReadAsync(array, 0, (int)size);
                            {
                               await sw.WriteAsync(array, 0, (int)size);
                            }
                        }
                    }
                }
                await Task.Run(()=>Console.WriteLine("Конец работы"));
            }
            catch (Exception e)
            {
                await Task.Run(()=>Console.WriteLine(e.Message));
            }
        }
    }
}
