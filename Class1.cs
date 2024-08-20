using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace simulation
{
    public enum Year
    {
        FirstYear = 1,
        SecondYear =2,
        ThirdYear =3,
        FourthYear =4
    };

    public class Student
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Course { get; set; }
        public Year Year { get; set; }
    }
    public class Subject
    {
        public int EDPCode { get; set; }
        public string SubName { get; set; }
        public string SubCourse { get; set; }
    }

    public class Teacher
    {
        public  string First { get; set; }
        public  string Last { get; set; }
        public  int ID { get; set; }
    }
    public class Department
    {
        public  string Name { get; set; }
        public int ID { get; set; }
        public  int TeacherID { get; set; }
    }
}
