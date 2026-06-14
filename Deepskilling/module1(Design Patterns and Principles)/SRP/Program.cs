using System;

class Student
{
    public string Name = "Prakash";
}

class StudentReport
{
    public void Print(Student s)
    {
        Console.WriteLine("Student Name: " + s.Name);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        StudentReport report = new StudentReport();
        report.Print(s);
    }
}
