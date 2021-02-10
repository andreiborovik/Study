using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Parallel
    {
        private int number;

        public Parallel(int number)
        {
            this.number = number;
        }
        public int Number
        {
            get => number;
            set => number = value;
        }
    }
}
