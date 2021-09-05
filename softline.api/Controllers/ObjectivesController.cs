using Microsoft.AspNetCore.Mvc;
using softline.core.Interfaces;
using softline.db.Model;

namespace softline.api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ObjectivesController : ControllerBase {

        private IObjectivesServices _objectivesServices;

        public ObjectivesController(IObjectivesServices objectivesServices) {
            _objectivesServices = objectivesServices;
        }

        [HttpGet]
        public IActionResult GetObjectives() {
            return Ok(_objectivesServices.GetObjectives());
        }

        [HttpGet("{id}", Name = "GetObjective")]
        public IActionResult GetObjective(int id) {
            return Ok(_objectivesServices.GetObjective(id));
        }

        [HttpPost]
        public IActionResult CreateObjective(Objective obj) {
            var newObjective = _objectivesServices.CreateObjective(obj);
            return CreatedAtRoute("GetObjective", new { newObjective.id }, newObjective);
        }

        [HttpDelete]
        public IActionResult DeleteObjective(Objective obj) {
            _objectivesServices.DeleteObjective(obj);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditObjective(Objective obj) {
            return Ok(_objectivesServices.EditObjective(obj));
        }
    }
}
