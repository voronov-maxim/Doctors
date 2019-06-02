using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class specializations
    {
        public specializations()
        {
            doctorspecializations = new HashSet<doctorspecializations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? PageId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual pages Page { get; set; }
        public virtual ICollection<doctorspecializations> doctorspecializations { get; set; }
    }
}
