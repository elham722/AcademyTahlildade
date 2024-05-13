using DataAccess.Services;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EducationDegreeRepository : IEducationDegreeRepository, IDisposable
    {
        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();

        public List<EducationDegree> GetAll()
        {
            return db.EducationDegrees.ToList();
        }
        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
