using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
