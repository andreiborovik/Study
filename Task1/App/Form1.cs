using System;
using System.Windows.Forms;
using System.IO;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Андреева\Университет\text.txt";
            string path1 = @"D:\Андреева\Университет\text1.txt";
            char[] array = new char[209715200];
            var file = new FileInfo(path);
            progressBar1.Maximum = (int)file.Length;
            progressBar1.Step = array.Length;
            long size;
            var time1 = DateTime.Now;
            try
            {
                using (StreamWriter sw = new StreamWriter(path1, false))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        for (int i = 0; i <= file.Length; i += array.Length)
                        {
                            var time2 = DateTime.Now;
                            if (file.Length - i > array.Length)
                            {
                                size = array.Length;
                            }
                            else size = file.Length - i;
                            await sr.ReadAsync(array, 0, (int)size);
                            await sw.WriteAsync(array, 0, (int)size);
                            progressBar1.PerformStep();
                            label1.Text = "Время выполнения шага: " + (DateTime.Now - time2).ToString();
                        }
                    }
                }
                label2.Text = "Время выполнения копирования: " + (DateTime.Now - time1).ToString();
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
