using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using DevOpsPortal.Models;

namespace DevOpsPortal.Controllers
{
    [ApiController]
    [Route("healthz")]
    public class SystemHealthController : ComonController<SystemHealthController>
    { 
        public SystemHealthController(ILogger<SystemHealthController> logger) : base(logger)
        {
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new SystemHealthModel());
        }
    }
}
