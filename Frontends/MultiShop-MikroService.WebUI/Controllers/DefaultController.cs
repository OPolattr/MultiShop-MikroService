using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
