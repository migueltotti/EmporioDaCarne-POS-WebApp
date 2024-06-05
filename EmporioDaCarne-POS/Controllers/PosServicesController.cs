using EmporioDaCarne_POS.Data;
using EmporioDaCarne_POS.Models.ViewModels;
using EmporioDaCarne_POS.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmporioDaCarne_POS.Controllers
{
    public class PosServicesController : Controller
    {
        private readonly EmporioDaCarne_POSContext _context;

        public PosServicesController(EmporioDaCarne_POSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = AppAuthentication();

            if (result != null)
            {
                return result;
            }

            var user = AuthenticationService.GetUserAuthenticated();
            var viewModel = new POSViewModel { User = user };

            return View(viewModel);
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
