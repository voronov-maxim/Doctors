using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class doctorspecializations
    {
        public int DoctorId { get; set; }
        public int SpecializationId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual doctors Doctor { get; set; }
        public virtual specializations Specialization { get; set; }
    }
}
