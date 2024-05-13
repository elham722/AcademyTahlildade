using DataAccess.Services;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TeacherRepository : ITeacherRepository, IDisposable
    {
        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();
        public int AddNew(Teacher te)
        {
           db.Teachers.Add(te);
            db.SaveChanges();
            return te.TeacherID;
        }

        public bool Delete(int TeacherId)
        {
            bool success = false;
            try
            {
                var tec = db.Teachers.FirstOrDefault(x => x.TeacherID == TeacherId);
                db.Teachers.Remove(tec);
                db.SaveChanges();
                success = true;
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }



        public Teacher Get(int TeacherID)
        {
            Teacher tec = db.Teachers.FirstOrDefault(x=> x.TeacherID==TeacherID);
            return tec;
        }

        public List<Teacher> GetAll()
        {
          return db.Teachers.ToList();
        }

        public bool Update(Teacher newTeacher)
        {
            bool success = false;
            try
            {
                var oldTeacher = db.Teachers.FirstOrDefault(x => x.TeacherID == newTeacher.TeacherID);
                oldTeacher.TeacherName = newTeacher.TeacherName;
                oldTeacher.Mobile = newTeacher.Mobile;
                oldTeacher.AboutTeacher = newTeacher.AboutTeacher;
                oldTeacher.ResumeDescription = newTeacher.ResumeDescription;
                db.SaveChanges();
                success = true;
            }
            catch(Exception ex)
            { 
                success = false;
            }
            return success;
        }
       

        public List<Teacher> Search(TeacherSearchModel teac)
        {
            var q = from item in db.Teachers select item;
            if (!string.IsNullOrEmpty(teac.TeacherName))
            {
                q = q.Where(x => x.TeacherName.StartsWith(teac.TeacherName));
            }
            if (!string.IsNullOrEmpty(teac.Mobile))
            {
                q = q.Where(x => x.Mobile.StartsWith(teac.Mobile));
            }

            return q.ToList();
        }
        public void AssignPictureToTeacher(int TeacherID ,string relativepath)
        {
            var t = db.Teachers.FirstOrDefault(x => x.TeacherID == TeacherID);
            t.Picture = relativepath;
            db.SaveChanges();
        }
        public void AssignResumeToTeacher(int TeacherID, string relativepath)
        {
            var t = db.Teachers.FirstOrDefault(x => x.TeacherID == TeacherID);
            t.Picture = relativepath;
            db.SaveChanges();
        }
        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
