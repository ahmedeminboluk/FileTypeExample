using FileTypeExample.API.Services;
using FileTypeExample.API.ViewModel;
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
    public class PushContentController : ControllerBase
    {
        private readonly IPushContentService _pushContentService;

        public PushContentController(IPushContentService pushContentService)
        {
            _pushContentService = pushContentService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(PushContentViewModel bigPara)
        {
            try
            {
                await _pushContentService.AddAsync(bigPara);
                return Ok();
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"Internal server error {ex}");
            }
            
            
        }
    }
}
