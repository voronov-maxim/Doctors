using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class localization
    {
        public int Id { get; set; }
        public int? CultureKeyHash { get; set; }
        public string CultureName { get; set; }
        public string _Path_ { get; set; }
        public string ResourceKey { get; set; }
        public string Value { get; set; }
    }
}
