using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<BigParaController> _logger;

        public BigParaController(IBigParaService bigParaService, ILogger<BigParaController> logger)
        {
            _bigParaService = bigParaService;
            _logger = logger;
        }

        [Produces("application/json")]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var bigPara = await _bigParaService.GetAllAsync();
            _logger.LogInformation("BigPara listelendi.");
            return Ok(bigPara);
        }
    }
}
