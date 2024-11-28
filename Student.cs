using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

public class Student : Person
{
    public List<Course> Courses { get; set; }

    public Student(string name, int id) : base(name, id)
    {
        Courses = new List<Course>();
    }

    public void Enroll(Course course)
    {
        Courses.Add(course);
        course.Students.Add(this);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, ID: {ID}");
    }
}

