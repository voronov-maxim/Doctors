using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class doctorschedules
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public int Day { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? LocationId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual doctors Doctor { get; set; }
        public virtual doctorschedulelocation Location { get; set; }
    }
}
