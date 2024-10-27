using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
