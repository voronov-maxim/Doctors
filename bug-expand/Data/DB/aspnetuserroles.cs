using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class aspnetuserroles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual aspnetroles Role { get; set; }
        public virtual aspnetusers User { get; set; }
    }
}
