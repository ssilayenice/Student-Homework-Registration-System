using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student:SchoolPerson
    {
        public Homework Homework { get; set; }

        public int Grade { get; set; }
        public bool IsSelected { set; get; }
    }
}
