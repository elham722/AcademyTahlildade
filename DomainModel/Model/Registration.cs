namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registration")]
    public partial class Registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registration()
        {
            Payments = new HashSet<Payment>();
        }

        public int RegistrationID { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public int EmployeeID { get; set; }

        public int Tuitionn { get; set; }

        public int TotalPayment { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }

        public virtual Course Course { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual Student Student { get; set; }
    }
}
