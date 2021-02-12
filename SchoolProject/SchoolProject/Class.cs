using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Class : Parallel
    {
        private char letter;
        private List<Student> students;
        private List<Teacher> teachers;
        private int count;

        public Class(char letter, List<Student> students, List<Teacher> teachers, int number) : base(number)
        {
            this.letter = letter;
            this.teachers = teachers;
            this.students = students;
            this.count = students.Count;
        }

        public char Letter
        {
            get => letter;
            set => letter = value;
        }

        public List<Student> Students
        {
            get => students;
            set => students = value;
        }
    }
}
