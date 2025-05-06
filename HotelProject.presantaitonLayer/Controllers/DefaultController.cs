using Microsoft.AspNetCore.Mvc;

namespace HotelProject.presantaitonLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
