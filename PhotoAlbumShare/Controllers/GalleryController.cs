using Microsoft.AspNetCore.Mvc;
using PhotoAlbumShare.Models;
using PhotoAlbumShare.Data;
using System.Linq;

namespace PhotoAlbumShare.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImage ImageService;

        public GalleryController(IImage imageService)
        {
            ImageService = imageService;
        }

        public IActionResult Index()
        {
            var imageList = ImageService.GetAll();
            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var image = ImageService.GetId(id);
            var model = new GalleryDetailModel()
            {
                Id = image.Id,
                Title = image.Title,
                Created = image.Created,
                Url = image.Url,
                Tags = image.Tags.Select(t => t.Description).ToList()
            };
            return View(model);
        }
    }
}