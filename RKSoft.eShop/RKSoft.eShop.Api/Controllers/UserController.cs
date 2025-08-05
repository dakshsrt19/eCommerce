using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RKSoft.eShop.Api.Controllers
{
    [Authorize(Roles = "User")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUserInfo()
        {
            // This endpoint can be used to return admin-specific information
            // For now, it just returns a simple message
            return Ok(new { Message = "User access granted." });
        }
    }
}
