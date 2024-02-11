using Introduction.DataAccess.Abstracts;
using Introduction.Entities;

namespace Introduction.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }
}
