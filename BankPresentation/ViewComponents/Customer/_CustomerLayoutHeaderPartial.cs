using Microsoft.AspNetCore.Mvc;

namespace BankPresentation.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}

