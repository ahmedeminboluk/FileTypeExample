using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.WebUI.ViewComponents
{
    public class AdvViewComponent : ViewComponent
    {
        private readonly IAdvService _advService;

        public AdvViewComponent(IAdvService advService)
        {
            _advService = advService;
        }

        public IViewComponentResult Invoke()
        {
            var adv = _advService.GetAll();
            return View(adv);
        }
    }
}
