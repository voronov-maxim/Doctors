using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class articletypes
    {
        public articletypes()
        {
            articlearticletypes = new HashSet<articlearticletypes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual ICollection<articlearticletypes> articlearticletypes { get; set; }
    }
}
