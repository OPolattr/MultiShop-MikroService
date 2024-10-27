using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult _UILayout()
		{
			return View();
		}
	}
}
