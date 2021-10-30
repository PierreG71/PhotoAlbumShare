using PhotoAlbumShare.Data.Models;
using System.Collections.Generic;

namespace PhotoAlbumShare.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }
    }
}
