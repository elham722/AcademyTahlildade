using DataAccess.Services;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TermRepository : ITermRepository, IDisposable
    {
       
        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();
        public List<Term> GetAll()
        {
            return db.Terms.ToList();
        }
        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
