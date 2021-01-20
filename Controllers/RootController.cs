using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using DevOpsPortal.Models;

namespace DevOpsPortal.Controllers
{
    [ApiController]
    [Route("")]
    public class RootController : ComonController<RootController>
    { 
        public RootController(ILogger<RootController> logger) : base(logger)
        {
        }

        [HttpGet]
        public ContentResult Get()
        {
            return Content((new RootModel()).ToString());
        }
    }
}
