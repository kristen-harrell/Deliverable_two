using KeiraTheCaticorn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeiraTheCaticorn.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ArtGalleryContext _db;
        public GalleryController(ArtGalleryContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
