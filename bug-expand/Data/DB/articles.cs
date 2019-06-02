using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class articles
    {
        public articles()
        {
            articlearticlecategories = new HashSet<articlearticlecategories>();
            articlearticletypes = new HashSet<articlearticletypes>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Metadata { get; set; }
        public string Content { get; set; }
        public string ShortContent { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ThumbImage { get; set; }

        public virtual ICollection<articlearticlecategories> articlearticlecategories { get; set; }
        public virtual ICollection<articlearticletypes> articlearticletypes { get; set; }
    }
}
