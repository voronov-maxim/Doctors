using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class pages
    {
        public pages()
        {
            departments = new HashSet<departments>();
            links = new HashSet<links>();
            specializations = new HashSet<specializations>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Metadata { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual ICollection<departments> departments { get; set; }
        public virtual ICollection<links> links { get; set; }
        public virtual ICollection<specializations> specializations { get; set; }
    }
}
