using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class GalleryVM
    {
        public GalleryVM()
        {
            Photos = new List<PhotoVM>();
        }

        public List<PhotoVM> Photos { get; set; }
        public int NumberOfPhotos { get; set; }
    }
}
