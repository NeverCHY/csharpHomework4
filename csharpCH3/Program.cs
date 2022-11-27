using System;
namespace GradePrint3
{
    public delegate bool GradePrint(Student s);
    public class Student
    {
        public Student() { }
        public GradePrint GP { get; set; }
        public void InvokeGradePrint()
        {
            GP(this);
        }
    }
    public class GradeReport
    {
        public static bool GradeReportOrderByTerm(Student s)
        {
            Console.WriteLine("成绩按学期排序");
            return true;
        }
    }
    class program
    {
        static void Main()
        {
            Student student1 = new Student();
            student1.GP = GradeReport.GradeReportOrderByTerm;
            student1.InvokeGradePrint();
        }
    }
}