using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
