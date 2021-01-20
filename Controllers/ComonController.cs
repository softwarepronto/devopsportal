using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevOpsPortal.Controllers
{
    public class ComonController<T> : ControllerBase
    { 
        protected readonly ILogger<T> _logger;

        protected ComonController(ILogger<T> logger)
        {
            _logger = logger;
        }
    }
}
