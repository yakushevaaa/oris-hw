using Fuck_API.Model;
using Fuck_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fuck_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IParsingService _parsingService;

        public ItemsController(IParsingService parsingService)
        {
            _parsingService = parsingService;
        }

        [HttpGet("api/parser")]
        public async Task<IActionResult> Parse(int pageNumber, int pageSize)
        {
            var result = await _parsingService.Parse(pageNumber, pageSize);
            return Ok(result);
        }

    }
}
