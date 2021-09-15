using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace FileTypeExample.WebUI.Controllers
{
    public class BigParaController : Controller
    {
        private readonly IBigParaService _bigParaService;
        private readonly HttpClient _httpClient;

        public BigParaController(IBigParaService bigParaService, HttpClient httpClient)
        {
            _bigParaService = bigParaService;
            _httpClient = httpClient;
        }

        public IActionResult OrderSpAz()
        {
            var bigPara = _bigParaService.GetBigParaSpAZ();
            return View(bigPara);
        }

        public IActionResult OrderSpZa()
        {
            var bigPara = _bigParaService.GetBigParaSpZA();
            return View(bigPara);
        }


        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<BigParaDto> bigPara = _bigParaService.GetBigParaWithSearch(search);
            return View(bigPara);
        }

        public  IActionResult BigPara()
        {
            var list2 = _bigParaService.GetAllCache(5);
            return View(list2);
        }

        [HttpPost]
        public IActionResult Order(string order)
        {
            IEnumerable<BigParaDto> bigPara = _bigParaService.GetBigParaOrder(order);
            return View(bigPara);
        }

        public async Task<IActionResult> GetAllAPI()
        {
            IEnumerable<BigParaDto> bigPara;
            bigPara = await _httpClient.GetFromJsonAsync<IEnumerable<BigParaDto>>($"{_httpClient.BaseAddress}BigPara/GetAll");
            return View(bigPara);
        }

        public IActionResult GetAllAjax()
        {
            return View();
        }
    }
}
