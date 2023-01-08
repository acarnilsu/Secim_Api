using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
