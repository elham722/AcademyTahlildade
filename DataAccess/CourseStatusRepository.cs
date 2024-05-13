using DataAccess.Services;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CourseStatusRepository : ICourseStatusRepository, IDisposable
    {
        private readonly AcademyTahlildadeContext db =new AcademyTahlildadeContext();
       
        public List<CourseStatu> GetAll()
        {
            return db.CourseStatus.ToList();
        }
        public void Dispose()
        {
            this.db.Dispose();
        }

    }
}
