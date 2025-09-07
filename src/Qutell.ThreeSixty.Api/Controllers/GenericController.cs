using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qutell.ThreeSixty.Application.DTOs;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Infrastructure.Repositories;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<TEntity, TKey> : ControllerBase where TEntity : class
    {
      
        private readonly ILookupCacheService<TEntity, TKey> _Service;

        public GenericController(ILookupCacheService<TEntity, TKey> Service)
        {
            _Service = Service;
           
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _Service.GetAllAsync();
            var result = entities.Select(e => new ReadDto<TKey, TEntity>
            {
                Id = (TKey)e.GetType().GetProperty("Id").GetValue(e),
                Entity = e
            });

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(TKey id)
        {
            var entity = await _Service.GetByIdAsync(id);
            if (entity == null) return NotFound();

            return Ok(new ReadDto<TKey, TEntity> { Id = id, Entity = entity });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDto<TEntity> dto)
        {
            await _Service.AddAsync(dto.Entity);
           

            return Ok(dto.Entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(TKey id, [FromBody] UpdateDto<TKey, TEntity> dto)
        {
            if (!id.Equals(dto.Id)) return BadRequest("Id mismatch.");

            _Service.UpdateAsync(dto.Entity);
            return Ok(dto.Entity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(TKey id)
        {
            await _Service.DeleteAsync(id);
            return NoContent();
        }
    }

}
