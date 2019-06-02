using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class departmentdoctors
    {
        public int DeparmentId { get; set; }
        public int DoctorId { get; set; }
        public string count { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual departments Deparment { get; set; }
        public virtual doctors Doctor { get; set; }
    }
}
