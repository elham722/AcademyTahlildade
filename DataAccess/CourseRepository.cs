using DataAccess.Services;
using DomainModel.Model;
using DomainModel.VeiwModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CourseRepository : ICourseRepository, IDisposable
    {
        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();
        public int AddNew(Course cur)
        {
           db.Courses.Add(cur);
            db.SaveChanges();
            return cur.CourseID;
        }

        public bool Delete(int CourseID)
        {
           bool success = false;
            try
            {
                var cur = db.Courses.FirstOrDefault(x => x.CourseID == CourseID);
                db.Courses.Remove(cur);
                db.SaveChanges();
                success = true;
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }

        

        public Course Get(int CourseID)
        {
            Course cur = db.Courses.FirstOrDefault(x => x.CourseID==CourseID);
            return cur;
        }

        public List<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public bool Update(Course newCourse)
        {
            bool success = false;
            try
            {
                var oldCourse = db.Courses.FirstOrDefault(x => x.CourseID == newCourse.CourseID);
                oldCourse.CourseName = newCourse.CourseName;
                oldCourse.Tuition = newCourse.Tuition;
                oldCourse.TeacherID = newCourse.TeacherID;
                oldCourse.Preq = newCourse.Preq;
                oldCourse.Day = newCourse.Day;
                oldCourse.Hours = newCourse.Hours;
                oldCourse.RuningTime = newCourse.RuningTime;
                oldCourse.StartDate = newCourse.StartDate;
                oldCourse.EndDate = newCourse.EndDate;
                oldCourse.CourseContent = newCourse.CourseContent;
                oldCourse.TermID = newCourse.TermID;
                oldCourse.CourseStatusID = newCourse.CourseStatusID;
                db.SaveChanges();
                success = true;

            }
            catch (Exception ex)
            {

            }
            return success;
        }

        public List<DomainModel.VeiwModel.CourseListItem> GetListCourseNew()
        {
          

            var q = from course in db.Courses
                    join teacher in db.Teachers
                    on course.TeacherID equals teacher.TeacherID
                    join term in db.Terms
                    on course.TermID equals term.TermID
                    join coursstatus in db.CourseStatus
                    on course.CourseStatusID equals coursstatus.CourseStatusID
                    select new DomainModel.VeiwModel.CourseListItem
                    {
                        CourseID = course.CourseID,
                        CourseName = course.CourseName,
                        TeacherName = teacher.TeacherName,
                        TermName = term.TermName,
                        CourseStatusName = coursstatus.CourseStatusName,
                        Tuition = course.Tuition,
                        Preq = course.Preq,
                        Day = course.Day,
                        Hours = course.Hours,
                        RuningTime = course.RuningTime,
                        StartDate = course.StartDate,
                        EndDate = course.EndDate,
                        CourseContent = course.CourseContent,
                    };
            return q.ToList();
        }

        public List<Course> Search(CourseSearchModel teac)
        {
            var q = from item in db.Courses select item;
            if (!string.IsNullOrEmpty(teac.CourseName))
            {
                q = q.Where(x => x.CourseName.StartsWith(teac.CourseName));
            }
            
            return  q.ToList();

        }
        public List<CorseREgister> Getcoursedropdown()
        {
            var q = from co in db.Courses
                    select new CorseREgister
                    {
                        CourseID = co.CourseID,
                        CourseName = co.CourseName,
                        Tuition=co.Tuition,
                    };
            return q.ToList();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
