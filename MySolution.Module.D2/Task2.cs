using MySolution.Module.D2;

namespace MySolution.D2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(nameof(Task))]
    public partial class Task2
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public int? AssignedTo_Id { get; set; }

        public int? Employee2_Id { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
