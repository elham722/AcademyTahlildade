using DataAccess.Services;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CityRepository : ICityRepository, IDisposable
    {


        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();

        public List<City> GetAll()
        {
            return db.Cities.ToList();
        }
        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
