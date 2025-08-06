using Microsoft.AspNetCore.Mvc;

namespace SIMS_dotNet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
