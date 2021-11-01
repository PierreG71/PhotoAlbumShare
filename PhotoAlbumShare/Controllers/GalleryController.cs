using Microsoft.AspNetCore.Mvc;
using PhotoAlbumShare.Models;
using PhotoAlbumShare.Data;

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
    }
}