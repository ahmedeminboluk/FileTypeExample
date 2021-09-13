using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileTypeExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BigParaController : ControllerBase
    {
        private readonly IBigParaService _bigParaService;

        public BigParaController(IBigParaService bigParaService)
        {
            _bigParaService = bigParaService;
        }

        [Produces("application/json")]
        [HttpGet("AllBigPara")]
        public async Task<IActionResult> GetAllUser()
        {
            var bigPara = await _bigParaService.GetAllAsync();
            return Ok(bigPara);
        }
    }
}
