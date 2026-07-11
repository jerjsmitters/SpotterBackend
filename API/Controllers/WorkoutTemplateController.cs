using Common.Business;
using Common.Dtos.ReferenceData;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/workout-template")]
    [ApiController]
    public class WorkoutTemplateController(IWorkoutTemplateService workoutTemplateService) : ControllerBase
    {
        private readonly IWorkoutTemplateService _workoutTemplateService = workoutTemplateService;

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutTemplateDto?>> Get(int id)
        {
            var template = await _workoutTemplateService.GetByIdAsync(id);

            if (template == null)
            {
                return NotFound();
            }

            return Ok(template);
        }

        [HttpPost]
        public async Task<ActionResult<WorkoutTemplateDto>> Post([FromBody] WorkoutTemplateDto workoutTemplate)
        {
            if (workoutTemplate.Id is not null)
            {
                return BadRequest("Id is provided");
            }

            var created = await _workoutTemplateService.CreateAsync(workoutTemplate);

            return Ok(created);
        }

        [HttpPut]
        public async Task<ActionResult<WorkoutTemplateDto>> Put([FromBody] WorkoutTemplateDto workoutTemplate)
        {
            if (workoutTemplate.Id is null)
            {
                return BadRequest("Id is not provided");
            }

            var updated = await _workoutTemplateService.UpdateAsync(workoutTemplate);

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _workoutTemplateService.DeleteAsync(id);
            return Ok();
        }
    }
}
