using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class departmentlocations
    {
        public int LocationId { get; set; }
        public int DepartmentId { get; set; }
        public string Info { get; set; }

        public virtual departments Department { get; set; }
        public virtual doctorschedulelocation Location { get; set; }
    }
}
