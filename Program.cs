using System;

class Program
{
    static void Main(string[] args)
    {
        // Öğretim Görevlisi Tanımlama
        Instructor instructor1 = new Instructor("Dr. Smith", 101);

        // Ders Tanımlama
        Course course1 = new Course("Mathematics", 3, instructor1);
        instructor1.Courses.Add(course1);

        // Öğrenci Tanımlama
        Student student1 = new Student("John Doe", 201);
        Student student2 = new Student("Jane Doe", 202);

        // Öğrencileri Derse Kayıt Etme
        student1.Enroll(course1);
        student2.Enroll(course1);

        // Bilgi Gösterme
        student1.DisplayInfo();
        student2.DisplayInfo();
        instructor1.DisplayInfo();
        course1.DisplayCourseInfo();
    }
}
