using Common.Business;
using Common.Dtos.Instance;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/workout-instance")]
    [ApiController]
    public class WorkoutInstanceController(IWorkoutInstanceService workoutInstanceService) : ControllerBase
    {
        private readonly IWorkoutInstanceService _workoutInstanceService = workoutInstanceService;

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutInstanceDto?>> Get(int id)
        {
            var workoutInstance = await _workoutInstanceService.GetByIdAsync(id);

            if (workoutInstance == null)
            {
                return NotFound();
            }

            return Ok(workoutInstance);
        }

        [HttpPost]
        public async Task<ActionResult<WorkoutInstanceDto>> Post([FromBody] WorkoutInstanceDto workoutInstance)
        {
            if (workoutInstance.Id is not null)
            {
                return BadRequest("Id is provided");
            }

            var createdWorkoutInstance = await _workoutInstanceService.CreateAsync(workoutInstance);

            return Ok(createdWorkoutInstance);
        }

        [HttpPut]
        public async Task<ActionResult<WorkoutInstanceDto>> Put([FromBody] WorkoutInstanceDto workoutInstance)
        {
            if (workoutInstance.Id is null)
            {
                return BadRequest("Id is not provided");
            }

            var updatedWorkoutInstance = await _workoutInstanceService.UpdateAsync(workoutInstance);

            return Ok(updatedWorkoutInstance);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _workoutInstanceService.DeleteAsync(id);
            return Ok();
        }
    }
}
