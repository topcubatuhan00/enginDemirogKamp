using Introduction.Entities;

namespace Introduction.Business;

public class CourseManager
{
    Course[] courses = new Course[2];
    public CourseManager()
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

        courses[0] = course;
        courses[1] = course1;
    }
    public Course[] GetAll()
    {
        return courses;
    }
}
