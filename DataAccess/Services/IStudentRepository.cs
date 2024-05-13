using DomainModel.Model;
using DomainModel.VeiwModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IStudentRepository
    {
        bool LoginStd(string UserName, string Password);
        int AddNew(Student s);
        void Delete(int StudentID);
        Student Get(int StudentID);
        List<Student> GetAll();
        void Update(Student newStudent);
        bool HasThisStudentAnyCourses(int StudentID);
       // List<combosListItem> GetAllCombosList();
       
        void AssignPictureToStudent(int StudentID, string RelativePath);
        List<combosListItem> Search(StudentSearchModel stud);

    }
}
