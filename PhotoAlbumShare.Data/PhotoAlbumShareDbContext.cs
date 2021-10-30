using Microsoft.EntityFrameworkCore;
using PhotoAlbumShare.Data.Models;

namespace PhotoAlbumShare.Data
{
    public class PhotoAlbumShareDbContext : DbContext
    {
        public PhotoAlbumShareDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
