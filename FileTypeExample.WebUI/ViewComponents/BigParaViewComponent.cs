using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.ViewComponents
{
    [ViewComponent]
    public class BigParaViewComponent : ViewComponent
    {
        private readonly IBigParaService _bigParaService;

        public BigParaViewComponent(IBigParaService bigParaService)
        {
            _bigParaService = bigParaService;
        }

        public IViewComponentResult Invoke()
        {
            var bigPara = _bigParaService.GetAll();
            return View(bigPara);
        }
    }
}
