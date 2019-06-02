using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class mediasharetouser
    {
        public string ToUserId { get; set; }
        public int MediaResourceId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual mediaresource MediaResource { get; set; }
        public virtual aspnetusers ToUser { get; set; }
    }
}
