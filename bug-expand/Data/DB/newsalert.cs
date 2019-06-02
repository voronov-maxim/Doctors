using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class newsalert
    {
        public int Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }
}
