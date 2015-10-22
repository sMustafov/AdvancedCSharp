using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.ClassStudent;

namespace Problem9.WeakStudents
{
    class WeakStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Ivanov", 28, 7111, "+359822545454", "pesho@mail.bg",
                    new List<int>() {6, 4, 5, 4, 3}, 2),
                new Student("Ivan", "Petkov", 20, 7118, "+3598221231354", "ivan@mail.bg",
                    new List<int>() {6, 6, 6, 4, 3}, 1),
                new Student("Dragan", "Rosenov", 18, 7141, "+3565652545454", "dragan@mail.bg",
                    new List<int>() {6, 2, 2, 6, 3}, 2),
                new Student("Ivo", "Draganov", 23, 7189, "+359822545156154", "ivo@mail.bg",
                    new List<int>() {6, 4, 4, 4, 4}, 1),
                new Student("Mariq", "Petrova", 21, 7154, "+35982252312134", "mariq@abv.bg",
                    new List<int>() {4, 4, 5, 4, 3}, 2),
                new Student("Petq", "Marinova", 32, 7112, "02/82251111154", "petq@mail.bg",
                    new List<int>() {4, 4, 2, 4, 3}, 1),
                new Student("Yordan", "Mariqnov", 19, 7177, "+359 28000005454", "yordan@mail.bg",
                    new List<int>() {5, 4, 3, 4, 3}, 2),
                new Student("Roksana", "Ivanova", 28, 7119, "+359282233333454", "roskana@abv.bg",
                    new List<int>() {5, 4, 5, 5, 3}, 1)
            };


            var marks = from student in students
                        where student.Marks.Count (x => x == 2) == 2
                        select student;

            foreach (var student in marks)
            {
                Console.WriteLine("Name: {0} {1}, Marks: {2}",
                    student.FirstName, student.LastName, string.Join(",", student.Marks));
            }
        }
    }
}
