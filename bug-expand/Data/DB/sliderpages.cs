using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class sliderpages
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public int? SliderId { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public virtual sliders Slider { get; set; }
    }
}
