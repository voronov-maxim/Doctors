using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class siteinfo
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
    }
}
