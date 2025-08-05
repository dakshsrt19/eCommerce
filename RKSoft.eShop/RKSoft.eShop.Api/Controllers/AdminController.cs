using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RKSoft.eShop.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAdminInfo()
        {
            // This endpoint can be used to return admin-specific information
            // For now, it just returns a simple message
            return Ok(new { Message = "Admin access granted." });
        }
    }
}
