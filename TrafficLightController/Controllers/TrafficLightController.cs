using Microsoft.AspNetCore.Mvc;

namespace TrafficLightController.Controllers
{
    public class TrafficLightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
