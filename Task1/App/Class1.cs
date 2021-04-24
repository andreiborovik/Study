using System;
using System.Threading.Tasks;
using System.IO;

namespace App1
{
    class Class1
    {
        //public void f()
        //{
        //    string path = @"D:\Андреева\Университет\text.txt";
        //    string path1 = @"D:\Андреева\Университет\text1.txt";
        //    char[] array = new char[209715200];
        //}

        public async void ReadWriteDataAsync(string path, string path1, char[] array, int i)
        {

            FileInfo file = new FileInfo(path);
            long size;
            await Task.Run(() => Console.WriteLine("Начало работы"));
            try
            {
                using (StreamWriter sw = new StreamWriter(path1, false))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        //for (int i = 0; i <= file.Length; i += array.Length)
                        //{
                            if (file.Length - i > array.Length) size = array.Length;
                            else size = file.Length - i;
                            await sr.ReadAsync(array, 0, (int)size);
                            {
                                await sw.WriteAsync(array, 0, (int)size);
                            }
                        //}
                    }
                }
                await Task.Run(() => Console.WriteLine("Конец работы"));
            }
            catch (Exception e)
            {
                await Task.Run(() => Console.WriteLine(e.Message));
            }
        }
    }
}
