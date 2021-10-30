using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhotoAlbumShare.Data.Models;
using PhotoAlbumShare.Models;

namespace PhotoAlbumShare.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var bikeImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Bikes",
                Id = 0
            };

            var tag2 = new ImageTag()
            {
                Description = "Adventure",
                Id = 1
            };

            var tag3 = new ImageTag()
            {
                Description = "Karoo",
                Id = 2
            };

            bikeImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Harley-Davidson Bikes",
                    Url = "https://images.pexels.com/photos/1796077/pexels-photo-1796077.jpeg",
                    Created = DateTime.Now,
                    Tags = bikeImageTags
                },

                new GalleryImage()
                {
                    Title = "Cool Dude",
                    Url = "https://images.pexels.com/photos/1808661/pexels-photo-1808661.jpeg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                },

                new GalleryImage()
                {
                    Title = "Where?",
                    Url = "https://images.pexels.com/photos/9989459/pexels-photo-9989459.jpeg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            };

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View();
        }
    }
}