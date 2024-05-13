using DataAccess.Services;
using DomainModel.Model;
using DomainModel.VeiwModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentRepository : IStudentRepository,IDisposable
    {
        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();

        public int AddNew(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
            return s.StudentID;
        }

        public void Delete(int StudentID)
        {
           db.Students.Remove(db.Students.FirstOrDefault(x => x.StudentID == StudentID));
            db.SaveChanges();
        }

      

        public Student Get(int StudentID)
        {
            return db.Students.FirstOrDefault(x => x.StudentID == StudentID);
        }

        public List<Student> GetAll()
        {
           return db.Students.ToList();
        }

        public bool HasThisStudentAnyCourses(int StudentID)
        {
            var s = db.Students.FirstOrDefault(x =>x.StudentID == StudentID);
            return s.Registrations.Any();
        }

        public bool LoginStd(string _UserName, string _Password)
        {
            bool exist = db.Students.Any(x => x.UserName == _UserName && x.Password == _Password);
            return exist;
        }

        public void Update(Student newStudent)
        {
            var oldStudent = db.Students.FirstOrDefault(x=> x.StudentID==newStudent.StudentID);
            oldStudent.FirstName = newStudent.FirstName;
            oldStudent.LastName = newStudent.LastName;
            oldStudent.NationalCode = newStudent.NationalCode;
            oldStudent.Mobile=newStudent.Mobile;
            oldStudent.Address = newStudent.Address;
            oldStudent.CityID = newStudent.CityID;
            oldStudent.ProvinceID = newStudent.ProvinceID;
            oldStudent.EducationDegreeID = newStudent.EducationDegreeID;
            oldStudent.FildOfStudy = newStudent.FildOfStudy;
            oldStudent.UserName = newStudent.UserName;
            oldStudent.Password = newStudent.Password;
            oldStudent.Picture = newStudent.Picture;

            db.SaveChanges();
        }


        public List<combosListItem> GetAllCombosList()
        {

            var students = db.Students
                .Include(x => x.City)
                .Include(x => x.EducationDegree)
                .Include(x => x.Province)
                .Select(x => new combosListItem
                {

                    StudentID = x.StudentID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    NationalCode = x.NationalCode,
                    Mobile = x.Mobile,
                    Address = x.Address,
                    ProvinceName = x.Province.ProvinceName,
                    CityName = x.City.CityName,
                    EducationDegreeName = x.EducationDegree.EducationDegreeName,
                    FildOfStudy = x.FildOfStudy,
                    UserName = x.UserName,
                    Password = x.Password,
                })
                .ToList<combosListItem>();
            return students;


            /*  var q = from student in db.Students
                      join province in db.Provinces
                      on student.ProvinceID equals province.ProvinceID
                      join city in db.Cities
                      on student.CityID equals city.CityID
                      join E in db.EducationDegrees
                      on student.EducationDegreeID equals E.EducationDegreeID
                      select new combosListItem
                      {
                         StudentID = student.StudentID,
                         FirstName = student.FirstName,
                         LastName = student.LastName,
                         NationalCode = student.NationalCode,
                         Mobile = student.Mobile,
                         Address = student.Address,
                         ProvinceName=province.ProvinceName,
                         CityName=city.CityName,
                         EducationDegreeName=E.EducationDegreeName,
                         FildOfStudy=student.FildOfStudy,
                         UserName=student.UserName,
                         Password=student.Password,
                      };
              return q.ToList();

           */

        }


        public void AssignPictureToStudent(int StudentID, string RelativePath)
        {
            var b = db.Students.FirstOrDefault(x => x.StudentID == StudentID);
            b.Picture = RelativePath;
            db.SaveChanges();
        }
        public List<combosListItem> Search(StudentSearchModel stud)
        {
            var q = from item in db.Students select item;
            if (!string.IsNullOrEmpty(stud.FirstName))
            {
                q = q.Where(x => x.FirstName.StartsWith(stud.FirstName));
            }
            if (!string.IsNullOrEmpty(stud.LastName))
            {
                q = q.Where(x => x.LastName.StartsWith(stud.LastName));
            }
            if (!string.IsNullOrEmpty(stud.NationalCode))
            {
                q = q.Where(x => x.NationalCode.StartsWith(stud.NationalCode));
            }

            return  q.Select(x => new combosListItem
               {

                   StudentID = x.StudentID,
                   FirstName = x.FirstName,
                   LastName = x.LastName,
                   NationalCode = x.NationalCode,
                   Mobile = x.Mobile,
                   Address = x.Address,
                   ProvinceName = x.Province.ProvinceName,
                   CityName = x.City.CityName,
                   EducationDegreeName = x.EducationDegree.EducationDegreeName,
                   FildOfStudy = x.FildOfStudy,
                   UserName = x.UserName,
                   Password = x.Password,
               }).ToList<combosListItem>();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }

        
    }
}
