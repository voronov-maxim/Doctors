using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class doctorschedulesexceptions
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual doctors Doctor { get; set; }
    }
}
