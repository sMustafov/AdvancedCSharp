using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Problem1.ClassStudent;

namespace Problem2.StudentsByGroup
{
    public class Problem2
    {
        static void Mainn()
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
                new Student("Mariq", "Petrova", 21, 7154, "+35982252312134", "mariq@mail.bg",
                    new List<int>() {4, 4, 5, 4, 3}, 2),
                new Student("Petq", "Marinova", 32, 7112, "+35982251111154", "petq@mail.bg",
                    new List<int>() {4, 4, 2, 4, 3}, 1),
                new Student("Yordan", "Mariqnov", 19, 7177, "+3598000005454", "yordan@mail.bg",
                    new List<int>() {5, 4, 3, 4, 3}, 2),
                new Student("Roksana", "Ivanova", 28, 7119, "+35982233333454", "roskana@mail.bg",
                    new List<int>() {5, 4, 5, 5, 3}, 1)
            };
            var byGroup = from student in students
            orderby student.FirstName
            group student by student.GroupNumber
            into studentGroup
            where studentGroup.Key == 2
            select studentGroup;
            foreach (var group in byGroup)
            {
                Console.WriteLine("Group: {0}", @group.Key);
                foreach (var student in @group)
                {
                    Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                                      "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}",
                        student.FirstName, student.LastName, student.Age, student.FacultyNumber,
                        student.Phone, student.Email, string.Join(", ", student.Marks));
                }
            }
        }
    }
}
