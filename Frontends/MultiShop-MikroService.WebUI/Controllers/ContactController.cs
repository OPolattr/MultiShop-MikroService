using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
