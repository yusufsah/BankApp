using Microsoft.AspNetCore.Mvc;

namespace BankPresentation.ViewComponents.Customer
{
    public class _CustomerLayoutNalbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
