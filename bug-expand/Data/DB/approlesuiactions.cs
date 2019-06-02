using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class approlesuiactions
    {
        public string RoleId { get; set; }
        public int UserActionId { get; set; }
        public int? PermisionId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual apppermission Permision { get; set; }
        public virtual aspnetroles Role { get; set; }
        public virtual uiaction UserAction { get; set; }
    }
}
