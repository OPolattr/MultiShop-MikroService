using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.ViewComponents.DefaultViewComponents
{
    public class _VendorDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
