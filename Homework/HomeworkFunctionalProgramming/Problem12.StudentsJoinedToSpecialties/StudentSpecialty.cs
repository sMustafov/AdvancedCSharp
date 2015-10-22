using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class StudentSpecialty
    {
        public StudentSpecialty(string name, int facNum)
        {
            this.NameOfSpecialty = name;
            this.FacNum = facNum;
        }

        public string NameOfSpecialty { get; set; }

        public int FacNum { get; set; }
    }
}