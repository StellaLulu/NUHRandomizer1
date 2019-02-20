namespace NUHRandomizer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResearchArm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResearchArm()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Strata { get; set; }

        [Required]
        [StringLength(1)]
        public string ARS { get; set; }

        public int OriginalCount { get; set; }

        public int RecruitedCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
