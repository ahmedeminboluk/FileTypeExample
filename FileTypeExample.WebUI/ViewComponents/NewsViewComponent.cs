using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.WebUI.ViewComponents
{
    public class NewsViewComponent : ViewComponent
    {
        private readonly INewsService _newsService;

        public NewsViewComponent(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IViewComponentResult Invoke()
        {
            var news = _newsService.GetAll();
            return View(news);
        }
    }
}
