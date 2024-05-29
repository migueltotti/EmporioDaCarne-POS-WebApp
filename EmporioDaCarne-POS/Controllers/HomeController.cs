using EmporioDaCarne_POS.Models;
using EmporioDaCarne_POS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmporioDaCarne_POS.Controllers
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
            var result = AppAuthentication();
            
            if(result != null)
            {
                return result;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            var result = AppAuthentication();

            if (result != null)
            {
                return result;
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public RedirectToActionResult AppAuthentication()
        {
            if (!AuthenticationService.GetAuthorization())
            {
                return RedirectToAction("Index", "Users");
            }

            return null;
        }
    }
}
