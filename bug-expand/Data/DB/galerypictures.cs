using System;
using System.Collections.Generic;

namespace ODATAT.Data.DB
{
    public partial class galerypictures
    {
        public int Id { get; set; }
        public int? PictureGaleryId { get; set; }
        public string FileName { get; set; }
        public string ImageHeading { get; set; }
        public string ImageSubHeading { get; set; }

        public virtual picturegalery PictureGalery { get; set; }
    }
}
