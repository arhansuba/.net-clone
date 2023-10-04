using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }

        public IActionResult MyCourses()
        {
            return View();
        }

        public IActionResult CourseDetail()
        {
            return View();
        }

        public IActionResult UserProfile(int userId)
        {
            UserProfile userProfile = GetProfileFromDatabase(userId);

            if (userProfile == null)
            {
                return NotFound();
            }

            return View(userProfile);
        }

        private UserProfile GetProfileFromDatabase(int userId)
        {
            // Veritabanından kullanıcı profilini getirme işlemi burada gerçekleştirilebilir.
            throw new NotImplementedException();
        }
    }
}

