using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [Produces("application/json")]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllBigPara()
        {
            var news = await _newsService.GetAllAsync();
            return Ok(news);
        }
    }
}
