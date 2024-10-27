using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.ViewComponents.ContactViewComponents
{
    public class _ContactDetailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
