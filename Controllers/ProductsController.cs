using Microsoft.AspNetCore.Mvc;

namespace SIMS_dotNet.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
