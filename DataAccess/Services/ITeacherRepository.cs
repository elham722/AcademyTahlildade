using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ITeacherRepository
    {
        int AddNew(Teacher te);
        List<Teacher> GetAll();
        bool Delete(int TeacherId);
        Teacher Get(int TeacherId);
        bool Update(Teacher te);
        List<Teacher> Search(TeacherSearchModel teac);
        void AssignPictureToTeacher(int TeacherID, string relativepath);
        void AssignResumeToTeacher(int TeacherID, string relativepath);

    }
}
