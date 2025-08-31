using Microsoft.AspNetCore.Mvc;

namespace SIMS_dotNet.Controllers
{
    public class UserRegistration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
