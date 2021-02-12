using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parallel> parallels = new List<Parallel>();
            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();
            List<Class> classes = new List<Class>();
            List<Class> classes1 = new List<Class>();
            Student Andrei = new Student(9, "Andrei", "Borovik", 24);
            Student Sasha = new Student(10, "Sasha", "Kot", 22);
            Student Masha = new Student(8, "Masha", "Ivanova", 18);
            Teacher Alexey = new Teacher("Alexey", "Astapchik", 24, ".NET");
            Class class1 = new Class('A', students, teachers, 1);
            Class class2 = new Class('B', students, teachers, 1);
            Service service = new Service();
            students.Add(Andrei);
            students.Add(Sasha);
            students.Add(Masha);
            teachers.Add(Alexey);
            parallels.Add(class1);
            parallels.Add(class2);
            classes.Add(class2);
            classes.Add(class1);
            School school = new School(parallels, 2, "Средняя школа");
            Show(students);
            var objects = from s in students                        //выборка
                          where s.Name.ToUpper().StartsWith("A")
                          select s;
            var obj = students.Where(s => s.Name.ToUpper().StartsWith("S")); //выборка
            Show(objects);
            Show(obj);
            objects = students.OrderBy(s => s.Mark);            //сортировка по возрастанию
            Show(objects);
            objects = students.OrderByDescending(s => s.Mark);  //сортировка по убыванию
            Show(objects);
            var set = from st in students
                      join t in teachers on st.Age equals t.Age
                      select new { Name = st.Name, Age = t.Age, Subject = t.Subject };
            Show(set);
            ///////////////////////////////////////////////////////////////////////////
            var o = service.MyWhere(students, s => s.Name.ToUpper().StartsWith("S"));
            Show(o);
            var j = service.MySelect(students, s => new { name = s.Name });
            Show(j);
            var a = service.MySelectMany(classes, c => c.Students, l => new { Name = l.Name });
            Show(a);
            bool m = service.MyAll(students, s => s.Age > 20);
            Console.WriteLine(m);
            m = service.MyAny(students, s => s.Age > 20);
            Console.WriteLine(m);
            var first = service.MyFirst(students);
            Console.WriteLine(first);
            var b = service.MyFirstOrDefault(classes1);
            Console.WriteLine(b);
        }

        public static void Show<T>(IEnumerable<T> i)
        {
            foreach (T s in i)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
        }
    }
}
        
