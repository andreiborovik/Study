using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Student : Person
    {
        private int mark;

        public Student (int mark, string name, string lastname, int age) : base(name, lastname, age)
        {
            this.mark = mark;
        }

        public int Mark
        {
            get => mark;
            set => mark = value;
        }

        public override string ToString()
        {
            return Mark.ToString() + " " + Name + " "  + Lastname + " " + Age.ToString();
        }

        
    }
}
