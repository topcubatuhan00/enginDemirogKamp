using Introduction.Entities;

namespace Introduction.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
}
