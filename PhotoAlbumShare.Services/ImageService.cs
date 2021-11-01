using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PhotoAlbumShare.Data.Models;
using PhotoAlbumShare.Data;
using System.Linq;

namespace PhotoAlbumShare.Services
{
    public class ImageService : IImage
    {
        private readonly PhotoAlbumShareDbContext Context;

        public ImageService(PhotoAlbumShareDbContext context)
        {
            Context = context;
        }

        public IEnumerable<GalleryImage> GetAll()
        {
            return Context.GalleryImages.Include(img => img.Tags);
        }

        public GalleryImage GetId(int id)
        {
            return Context.GalleryImages.Find(id);
        }

        public IEnumerable<GalleryImage> GetTag(string tag)
        {
            return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
