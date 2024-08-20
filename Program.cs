using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simulation;


namespace simulation
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> student = Class2.GetStudent();
            List<Subject> subject = Class2.GetSubjects();
            List<Teacher> teacher = Class2.GetTeacher();
            List<Department> department = Class2.GetDepartment();

            //STUDENT LAMBDA
            var allStudents = student.Select(stdnt => stdnt);
            //var allStudents = student.Where(stdnt => stdnt.ID == 11111);

            foreach (var stdnt in allStudents)
            {
                Console.WriteLine($"ID: {stdnt.ID}");
                Console.WriteLine($"Name: {stdnt.Fname} {stdnt.Lname}");
                Console.WriteLine($"Course: {stdnt.Course}");
                Console.WriteLine($"Year: {stdnt.Year}");
                Console.WriteLine();
            }

            //STUDENT LINQ
            var query = from student1 in student
                        select student1 ;

            foreach (var stdnt in query)
            {
                Console.WriteLine($"ID: {stdnt.ID}");
                Console.WriteLine($"Name: {stdnt.Fname} {stdnt.Lname}");
                Console.WriteLine($"Course: {stdnt.Course}");
                Console.WriteLine($"Year: {stdnt.Year}");
                Console.WriteLine();
            }



            /*
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            Console.WriteLine();
            
            /*
            IEnumerable<string> wordFilterQuery = 
            from dinosaur in dinosaurs
            where dinosaur == "Tyrannosaurus" 
            select dinosaur;
            */
            /*
            var specificDinosaurs = dinosaurs.Where(d => d.StartsWith("A") && d.Length > 10);

            foreach (string dinosaur in specificDinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            */

            Console.ReadLine();

        }
    }
}
