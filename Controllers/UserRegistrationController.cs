using Microsoft.AspNetCore.Mvc;

namespace SIMS_dotNet.Controllers
{
    public class UserRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
