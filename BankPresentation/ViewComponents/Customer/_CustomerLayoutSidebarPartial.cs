﻿using Microsoft.AspNetCore.Mvc;

namespace BankPresentation.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
