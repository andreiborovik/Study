using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Person 
    {
        private string name;
        private string lastname;
        private int age;

        public Person (string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

    }
}
