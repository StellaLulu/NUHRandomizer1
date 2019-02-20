namespace NUHRandomizer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string PatientId { get; set; }

        [Required]
        [StringLength(20)]
        public string TrialId { get; set; }

        public int ResearchArmsId { get; set; }

        public int HospitalId { get; set; }

        public int RecruitStatusId { get; set; }

        public DateTime RecruitDate { get; set; }

        public string Remarks { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual RecruitmentStatu RecruitmentStatu { get; set; }

        public virtual ResearchArm ResearchArm { get; set; }
    }
}
