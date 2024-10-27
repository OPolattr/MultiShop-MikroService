using Microsoft.AspNetCore.Mvc;

namespace MultiShop_MikroService.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListGetProductCountComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {  return View(); }
    }
}
