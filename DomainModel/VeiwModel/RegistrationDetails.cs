using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.VeiwModel
{
    public class RegistrationDetails
    {

        public int RegistrationID { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string CourseName { get; set; }
        public string Tuition { get; set; }
        

        public string StudentFullInfo { get; set; }

        public string UserName { get; set; }

        public int Tuitionn { get; set; }

        public int TotalPayment { get; set; }

        public string Description { get; set; }
    }
}
