using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IRegistrationRepository
    {
        int RegisterationSabteName(Registration o);
        int RegistrationPayment(Payment re);
        List<DomainModel.VeiwModel.RegistrationDetails> GetListRegistrationDetails();
    }
}
