using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class picturegalery
    {
        public picturegalery()
        {
            galerypictures = new HashSet<galerypictures>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<galerypictures> galerypictures { get; set; }
    }
}
