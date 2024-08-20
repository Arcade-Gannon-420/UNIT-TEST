using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    //Class
    public static class Class2
    {
        public static List<Student> GetStudent()
        {
            List<Student> student = new List<Student>();

            Student student1 = new Student
            {
                ID = 11111,
                Fname = "Test1",
                Lname = "Test1",
                Course = "BSCPE",
                Year = Year.FirstYear
            };
            student.Add(student1);

            student1 = new Student
            {
                ID = 22222,
                Fname = "Test2",
                Lname = "Test2",
                Course = "BSCPE",
                Year = Year.FirstYear
            };
            student.Add(student1);

            student1 = new Student
            {
                ID = 3333,
                Fname = "Test3",
                Lname = "Test3",
                Course = "BSCPE",
                Year = Year.FirstYear
            };
            student.Add(student1);

            return student;
        }

        public static List<Subject> GetSubjects()
        {
            List<Subject> subject = new List<Subject>();

            Subject subject1 = new Subject
            {
                EDPCode = 2020,
                SubName = "Rigid Body",
                SubCourse = "BSCE"
            };
            subject.Add(subject1);

            subject1 = new Subject
            {
                EDPCode = 3211,
                SubName = "CPE LAW",
                SubCourse = "BSCPE"
            };
            subject.Add(subject1);

            subject1 = new Subject
            {
                EDPCode = 6612,
                SubName = "College Math",
                SubCourse = "BSME"
            };
            subject.Add(subject1);

            subject1 = new Subject
            {
                EDPCode = 4214,
                SubName = "CAD",
                SubCourse = "BSME"
            };
            subject.Add(subject1);

            return subject;
        }

        public static List<Teacher> GetTeacher()
        {
            List<Teacher> teacher = new List<Teacher>();

            Teacher teacher1 = new Teacher
            {
                ID = 123,
                First = "Kaloy E",
                Last = "Kami"
            };
            teacher.Add(teacher1);

            teacher1 = new Teacher
            {
                ID = 123,
                First = "Pala",
                Last = "Utog"
            };
            teacher.Add(teacher1);

            return teacher;
        }
        public static List<Department> GetDepartment()
        {
            List<Department> department = new List<Department>();

            Department department1 = new Department
            {
                ID = 2020,
                Name = "Computer Engineering",
                TeacherID = 123
            };
            department.Add(department1);

            department1 = new Department
            {
                ID = 2021,
                Name = "Mechanical Engineering",
                TeacherID = 123
            };
            department.Add(department1);

            department1 = new Department
            {
                ID = 2022,
                Name = "Industrial Engineering",
                TeacherID = 456
            };
            department.Add(department1);

            department1 = new Department
            {
                ID = 2023,
                Name = "Electical Engineering",
                TeacherID = 456
            };
            department.Add(department1);

            return department;
        }
    }
}
