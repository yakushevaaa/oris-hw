using CarBooking.Data;
using CarBooking.Models;
using CarBooking.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public CommentsController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetCarComment")]
        public IEnumerable<Comment> Get(int id)
            => _dbContext.Comments.Where(x => x.CarId == id);
    }
}
