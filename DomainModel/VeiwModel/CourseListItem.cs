using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.VeiwModel
{
    public class CourseListItem
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Tuition { get; set; }
        public string TeacherName { get;set; }

        public string Preq { get; set; }

       
        public string Day { get; set; }

        public int Hours { get; set; }

        
        public string RuningTime { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CourseContent { get; set; }

        public string TermName { get; set; }

        public string CourseStatusName { get; set; }

    }
}
