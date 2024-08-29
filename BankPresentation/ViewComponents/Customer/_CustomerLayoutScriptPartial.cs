using Microsoft.AspNetCore.Mvc;

namespace BankPresentation.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial: ViewComponent
    {

         public IViewComponentResult Invoke()
        {
            return View();
        } 
    }
}
