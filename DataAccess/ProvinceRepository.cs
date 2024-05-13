using DataAccess.Services;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProvinceRepository : IProvinceRepository, IDisposable
    {
        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();

        public List<Province> GetAll()
        {
           return db.Provinces.ToList();
        }
        public void Dispose()
        {
           this.db.Dispose();
        }
    }
}
