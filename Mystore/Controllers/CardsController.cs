using Microsoft.AspNetCore.Mvc;

namespace Mystore.Controllers
{
    public class CardsController : Controller
    {
        [Route("cards/{id}")]
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
