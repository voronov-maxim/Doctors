using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class clientappointments
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public string ClientId { get; set; }
        public int? DepartamentId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string Comments { get; set; }
        public int? Approved { get; set; }
        public int? LocationId { get; set; }
        public int? Day { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public int UserChildId { get; set; }
        public string Observatii { get; set; }

        public virtual aspnetusers Client { get; set; }
        public virtual doctors Doctor { get; set; }
        public virtual userchildren UserChild { get; set; }
    }
}
