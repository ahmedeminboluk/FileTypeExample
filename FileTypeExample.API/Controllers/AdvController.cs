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
    public class AdvController : ControllerBase
    {
        private readonly IAdvService _advService;

        public AdvController(IAdvService advService)
        {
            _advService = advService;
        }

        [Produces("application/json")]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllBigPara()
        {
            var adv = await _advService.GetAllAsync();
            return Ok(adv);
        }
    }
}
