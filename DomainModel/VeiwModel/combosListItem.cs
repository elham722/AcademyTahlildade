using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.VeiwModel
{
    public class combosListItem
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalCode { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string ProvinceName { get; set; }

        public string CityName { get; set; }

        public string EducationDegreeName { get; set; }

        public string FildOfStudy { get; set; }

        public string Picture { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

    }
}
