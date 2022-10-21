using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
