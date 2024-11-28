using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

public class Instructor : Person
{
    public List<Course> Courses { get; set; }

    public Instructor(string name, int id) : base(name, id)
    {
        Courses = new List<Course>();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Instructor: {Name}, ID: {ID}");
    }
}
