using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Teacher : Person
    {
        private string subject;

        public Teacher(string name, string lastname, int age, string subject) : base (name, lastname, age)
        {
            this.subject = subject;
        }

        public string Subject
        {
            get => subject;
            set => subject = value;
        }
    }
}
