using LMS_API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentStateController : ControllerBase
    {
        LMSContext _context = new LMSContext();

        [HttpGet("GetAllState")]
        public IActionResult GetAllState()
        {
            var studentStates = _context.StudentStates.ToList();
            return Ok(studentStates);
        }
    }
}
