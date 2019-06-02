using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class doctorschedulelocation
    {
        public doctorschedulelocation()
        {
            departmentlocations = new HashSet<departmentlocations>();
            doctorschedules = new HashSet<doctorschedules>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<departmentlocations> departmentlocations { get; set; }
        public virtual ICollection<doctorschedules> doctorschedules { get; set; }
    }
}
