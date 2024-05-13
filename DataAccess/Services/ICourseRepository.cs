using DomainModel.Model;
using DomainModel.VeiwModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ICourseRepository
    {
        int AddNew(Course cur);
        List<Course> GetAll();
        bool Delete(int CourseID);
        Course Get(int CourseID);
        bool Update(Course cur);
        List<CourseListItem> GetListCourseNew();
        List<CorseREgister> Getcoursedropdown();
    }
}
