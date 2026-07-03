using DTOs.ReferenceData;
using Microsoft.AspNetCore.Mvc;
using Services.Public;

namespace API.Controllers
{
    [Route("api/movement")]
    [ApiController]
    public class MovementController : ControllerBase
    {
        private IMovementService _movementService { get; }

        public MovementController(IMovementService movementService)
        {
            this._movementService = movementService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovementDto?>> Get(int id)
        {
            var movement = await _movementService.GetByIdAsync(id);

            if (movement == null)
            {
                return NotFound();
            }

            return Ok(movement);
        }

        [HttpPost]
        public async Task<ActionResult<MovementDto>> Post([FromBody] MovementDto movement)
        {
            if (movement.Id is not null)
            {
                return BadRequest("Id is provided");
            }

            var created = await _movementService.CreateAsync(movement);

            return Ok(created);
        }

        [HttpPut]
        public async Task<ActionResult<MovementDto>> Put([FromBody] MovementDto movement)
        {
            if (movement.Id is null)
            {
                return BadRequest("Id is not provided");
            }

            var updated = await _movementService.UpdateAsync(movement);

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _movementService.DeleteAsync(id);
            return Ok();
        }
    }
}
