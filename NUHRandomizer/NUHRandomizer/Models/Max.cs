namespace NUHRandomizer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Max")]
    public partial class Max
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Recruitment { get; set; }
    }
}
