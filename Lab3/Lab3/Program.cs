using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Sufian";
            s.Id = "19-39292-1";
            s.Department = "CSE";
            s.Cgpa = 3.47f;
            s.ShowInfo();
            Triangle t = new Triangle();
            t.X = 5;
            t.X = 6;
            t.Z = 7;
            t.ShowInfo();
            t.TestTriangle();
            Account a = new Account();
            a.AccName = "My Account";
            a.AcId = "1";
            a.Balance = 1000;
            a.Deposit(25);
            a.Withdraw(50);
            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseId = "1022";
            c.CourseCredit = 3;
            c.ShowCourseInfo();
        }
    }

}
