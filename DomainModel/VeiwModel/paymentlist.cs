using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.VeiwModel
{
    public class paymentlist
    {
      public int PaymentID { get; set; }    
        public int Amount { get; set; }
        public string RegistrationName { get; set; }
        public DateTime PaymentDate { get; set; }
        public int EmployeeID { get; set; }
    }
}
