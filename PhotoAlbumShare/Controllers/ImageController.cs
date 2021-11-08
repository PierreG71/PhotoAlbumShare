using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PhotoAlbumShare.Models;

namespace PhotoAlbumShare.Controllers
{
    public class ImageController : Controller
    {
        private IConfiguration Config;
        private string AzureStorageConnectionString { get; }

        public ImageController(IConfiguration config)
        {
            Config = config;
            AzureStorageConnectionString = Config["AzureStorageConnectionString"];
        }

        public IActionResult Upload()
        {
            var model = new UploadImageModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult UploadNewImage()
        {
            return Ok();
        }
    }
}