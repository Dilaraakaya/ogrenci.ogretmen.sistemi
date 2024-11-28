using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

public class Course
{
    public string CourseName { get; set; }
    public int Credits { get; set; }
    public Instructor Instructor { get; set; }
    public List<Student> Students { get; set; }

    public Course(string courseName, int credits, Instructor instructor)
    {
        CourseName = courseName;
        Credits = credits;
        Instructor = instructor;
        Students = new List<Student>();
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Credits: {Credits}, Instructor: {Instructor.Name}");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in Students)
        {
            Console.WriteLine($"- {student.Name} (ID: {student.ID})");
        }
    }
}

