using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class aspnetroles
    {
        public aspnetroles()
        {
            approlesuiactions = new HashSet<approlesuiactions>();
            aspnetroleclaims = new HashSet<aspnetroleclaims>();
            aspnetuserroles = new HashSet<aspnetuserroles>();
            mediasharetogroup = new HashSet<mediasharetogroup>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<approlesuiactions> approlesuiactions { get; set; }
        public virtual ICollection<aspnetroleclaims> aspnetroleclaims { get; set; }
        public virtual ICollection<aspnetuserroles> aspnetuserroles { get; set; }
        public virtual ICollection<mediasharetogroup> mediasharetogroup { get; set; }
    }
}
