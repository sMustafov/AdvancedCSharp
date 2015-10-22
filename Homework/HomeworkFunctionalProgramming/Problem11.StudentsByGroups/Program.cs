using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.ClassStudent;
namespace Problem11.StudentsByGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Ivanov", 28, 711114, "+359822545454", "pesho@mail.bg",
                    new List<int>() {6, 4, 5, 4, 3}, "C#"),
                new Student("Ivan", "Petkov", 20, 711845, "+3598221231354", "ivan@mail.bg",
                    new List<int>() {6, 6, 6, 4, 3}, "JAVA"),
                new Student("Dragan", "Rosenov", 18, 714114, "+3565652545454", "dragan@mail.bg",
                    new List<int>() {6, 2, 2, 6, 3}, "C#"),
                new Student("Ivo", "Draganov", 23, 718978, "+359822545156154", "ivo@mail.bg",
                    new List<int>() {6, 4, 4, 4, 4}, "C++"),
                new Student("Mariq", "Petrova", 21, 715411, "+35982252312134", "mariq@abv.bg",
                    new List<int>() {4, 4, 5, 4, 3}, "C++"),
                new Student("Petq", "Marinova", 32, 711233, "02/82251111154", "petq@mail.bg",
                    new List<int>() {4, 4, 2, 4, 3}, "JAVA"),
                new Student("Yordan", "Mariqnov", 19, 717769, "+359 28000005454", "yordan@mail.bg",
                    new List<int>() {5, 4, 3, 4, 3}, "C#"),
                new Student("Roksana", "Ivanova", 28, 711914, "+359282233333454", "roskana@abv.bg",
                    new List<int>() {5, 4, 5, 5, 3}, "JAVA")
            };


            var studGroups = from student in students
                         group student by student.GroupName
                         into groups 
                         orderby groups.Key
                         select groups;

            foreach (var group in studGroups)
            {
                Console.WriteLine("Group Name : {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("Name : {0} {1}, Faculty Number : {2}",student.FirstName,student.LastName,student.FacultyNumber);
                }
            }
        }
    }
}
