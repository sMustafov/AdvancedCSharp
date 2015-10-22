using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Student
    {
        public Student(int facNumm, string name)
        {
            this.FacNumm = facNumm;
            this.Name = name;
        }

        public int FacNumm { get; set; }

        public string Name { get; set; }
    }
}