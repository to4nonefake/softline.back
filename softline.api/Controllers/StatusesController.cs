using Microsoft.AspNetCore.Mvc;
using softline.core.Interfaces;

namespace softline.api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class StatusesController : ControllerBase {
        
        private IStatusesServices _statusServices;

        public StatusesController(IStatusesServices statusServices) {
            _statusServices = statusServices;
        }

        [HttpGet]
        public IActionResult GetObjectives() {
            return Ok(_statusServices.GetStatuses());
        }
    }
}
