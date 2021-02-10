using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class School
    {
        private List<Parallel> parallels;
        private int number;
        private string name;

        public School(List<Parallel> parallels, int number, string name)
        {
            this.parallels = parallels;
            this.number = number;
            this.name = name;
        }

        public List<Parallel> Parallels
        {
            get => parallels;
            set => parallels = value;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
