using System.Collections.Generic;
using PhotoAlbumShare.Data.Models;

namespace PhotoAlbumShare.Data
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();
        IEnumerable<GalleryImage> GetTag(string tag);
        GalleryImage GetId(int id);
    }
}
