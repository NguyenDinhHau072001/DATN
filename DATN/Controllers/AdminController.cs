using Microsoft.AspNetCore.Mvc;

namespace DATN.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
