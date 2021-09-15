using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileTypeExample.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IBigParaService _bigParaService;
        private readonly IMapper _mapper;

        public AdminController(IAdminService adminService, IBigParaService bigParaService, IMapper mapper)
        {
            _adminService = adminService;
            _bigParaService = bigParaService;
            _mapper = mapper;

        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BigPara()
        {
            IEnumerable<BigParaDto> bigPara = await _adminService.GetAllBigParaAsync();
            return View(bigPara);
        }

        public async Task<IActionResult> BigParaEdit(int id)
        {
            BigParaDto bigPara = await _adminService.GetByIdBigParaAsync(id);
            return View(bigPara);
        }
        [HttpPost]
        public IActionResult BigParaEdit(BigParaDto entity)
        {
            BigParaDto bigPara = _adminService.UpdateBigPara(entity);
            if (bigPara != null) return RedirectToAction("BigPara");
            return View(entity);
        }

        public async Task<IActionResult> News()
        {
            IEnumerable<NewsDto> news = await _adminService.GetAllNewsAsync();
            return View(news);
        }

        public async Task<IActionResult> NewsEdit(int id)
        {
            NewsDto news = await _adminService.GetByIdNewsAsync(id);
            return View(news);
        }
        [HttpPost]
        public IActionResult NewsEdit(NewsDto entity)
        {
            NewsDto news = _adminService.UpdateNews(entity);
            if (news != null) return RedirectToAction("News");
            return View(entity);
        }

        public async Task<IActionResult> Adv()
        {
            IEnumerable<AdvDto> adv = await _adminService.GetAllAdvAsync();
            return View(adv);
        }

        public async Task<IActionResult> AdvEdit(int id)
        {
            AdvDto adv = await _adminService.GetByIdAdvAsync(id);
            return View(adv);
        }
        [HttpPost]
        public IActionResult AdvEdit(AdvDto entity)
        {
            AdvDto adv = _adminService.UpdateAdv(entity);
            if (adv != null) return RedirectToAction("Adv");
            return View(entity);
        }

        public async Task<IActionResult> AddMongo(PushContent content)
        {
            var result = await _adminService.AddMongoAsync(content);
            if (result == true) return RedirectToAction("Index");
            return RedirectToAction("BigPara");
        }
    }
}
