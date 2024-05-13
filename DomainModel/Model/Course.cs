namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Registrations = new HashSet<Registration>();
        }

        public int CourseID { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(100)]
        public string Tuition { get; set; }

        public int TeacherID { get; set; }

        [Required]
        [StringLength(100)]
        public string Preq { get; set; }

        [Required]
        [StringLength(50)]
        public string Day { get; set; }

        public int Hours { get; set; }

        [Required]
        [StringLength(100)]
        public string RuningTime { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public string CourseContent { get; set; }

        public int TermID { get; set; }

        public int CourseStatusID { get; set; }

        public virtual CourseStatu CourseStatu { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Term Term { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
