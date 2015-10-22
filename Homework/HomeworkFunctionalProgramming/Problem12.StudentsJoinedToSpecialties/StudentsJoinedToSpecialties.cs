using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3;

namespace StudentsJoinedToSpecialties
{
    class StudentsJoinedToSpecialties
    {
        static void Main(string[] args)
        {
            List<StudentSpecialty> specialties = new List<StudentSpecialty>()
            {
                new StudentSpecialty("Web Developer", 203314),
                new StudentSpecialty("Web Developer", 203114),
                new StudentSpecialty("PHP Developer", 203814),
                new StudentSpecialty("PHP Developer", 203914),
                new StudentSpecialty("QA Engineer", 203314),
                new StudentSpecialty("Web Developer", 203914)
            };

            List<Student> students = new List<Student>()
            {
                new Student(205114, "Milena Kirova"),
                new Student(203114, "Stefan Popov"),
                new Student(203314, "Asya Manova"),
                new Student(203914, "Diana Petrova"),
                new Student(203814, "Ivan Ivanov")
            };
 
            var result = from specialty in specialties
                join student in students on specialty.FacNum equals student.FacNumm
                select new {student.Name, student.FacNumm, specialty.NameOfSpecialty};
            foreach (var finalResult in result)
            {
                Console.WriteLine("| {0} | {1} | {2} |", finalResult.Name, finalResult.FacNumm, finalResult.NameOfSpecialty);
            }
        }
    }
}
