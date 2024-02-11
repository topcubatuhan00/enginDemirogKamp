using Introduction.DataAccess.Abstracts;
using Introduction.Entities;

namespace Introduction.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course = new Course();
        course.Id = 1;
        course.Name = "C#";
        course.Description = ".Net 8";
        course.Price = 0;

        Course course1 = new Course();
        course1.Id = 2;
        course1.Name = "Java";
        course1.Description = "Eclipse";
        course1.Price = 100;

        courses = new List<Course> { course, course1 };
    }

    public List<Course> GetAll()
    {
        // db de bulunan bütün kurslar listelenir.
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}