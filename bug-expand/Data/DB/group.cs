using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class group
    {
        public group()
        {
            aspnetusers = new HashSet<aspnetusers>();
            leftsidebaritems = new HashSet<leftsidebaritems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<aspnetusers> aspnetusers { get; set; }
        public virtual ICollection<leftsidebaritems> leftsidebaritems { get; set; }
    }
}
