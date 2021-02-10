using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject
{
    class Program
    {
        //delegate bool q<T>(T obj);
        static void Main(string[] args)
        {
            //q<Student> qq = yes;
            List<Parallel> parallels = new List<Parallel>();
            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();
            Student Andrei = new Student(9, "Andrei", "Borovik", 24);
            Student Sasha = new Student(10, "Sasha", "Kot", 22);
            Student Masha = new Student(8, "Masha", "Ivanova", 18);
            Teacher Alexey = new Teacher("Alexey", "Astapchik", 24, ".NET");
            Class class1 = new Class('A', students, teachers, 1);
            students.Add(Andrei);
            students.Add(Sasha);
            students.Add(Masha);
            teachers.Add(Alexey);
            parallels.Add(class1);
            School school = new School(parallels, 2, "Средняя школа");
            Show(students);
            var objects = from s in students                        //выборка
                          where s.Name.ToUpper().StartsWith("A")
                          select s;
            var obj = students.Where(s => s.Name.ToUpper().StartsWith("M")); //выборка
            Show1(objects);
            Show1(obj);
            objects = students.OrderBy(s => s.Mark);            //сортировка по возрастанию
            Show1(objects);
            objects = students.OrderByDescending(s => s.Mark);  //сортировка по убыванию
            Show1(objects);
            var set = from st in students
                      join t in teachers on st.Age equals t.Age
                      select new { Name = st.Name, Age = t.Age, Subject = t.Subject };
            Show1(set);
        }
        public static void Show<T>(List<T> i)
        {
            foreach (T s in i)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
        }

        public static void Show1<T>(IEnumerable<T> i)
        {
            foreach (T s in i)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
        }
        //public static bool yes(Student s)
        //{
        //    return s.Name.ToUpper().StartsWith("M");
        //}
    }
}
