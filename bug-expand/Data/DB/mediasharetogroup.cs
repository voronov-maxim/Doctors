using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class mediasharetogroup
    {
        public string ToGroupId { get; set; }
        public int MediaResourceId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual mediaresource MediaResource { get; set; }
        public virtual aspnetroles ToGroup { get; set; }
    }
}
