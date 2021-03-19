using KeiraTheCaticorn.DataAccess;
using KeiraTheCaticorn.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KeiraTheCaticorn.Controllers
{
    public class HomeController : Controller
    {

        private readonly ArtDAL _dal;
        public HomeController(ArtDAL dal)
        {
            _dal = dal;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Art()
        {
            Rootobject rootobjects = _dal.GetGallery();

            return View(rootobjects);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
