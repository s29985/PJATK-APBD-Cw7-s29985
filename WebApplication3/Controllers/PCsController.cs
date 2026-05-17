using Microsoft.AspNetCore.Mvc;
using WebApplication3.DTOs;
using WebApplication3.Services;

namespace WebApplication3.Controllers;

[Route("api/pcs")]
[ApiController]
public class PCsController : ControllerBase
{
    private readonly IPcService _pcService;

    public PCsController(IPcService pcService)
    {
        _pcService = pcService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PCListDto>>> GetAll()
    {
        var pcs = await _pcService.GetAllAsync();
        return Ok(pcs); 
    }

    [HttpGet("{id}/components")]
    public async Task<ActionResult<PCDetailDto>> GetByIdWithComponents(int id)
    {
        var pc = await _pcService.GetByIdWithComponentsAsync(id);
        if (pc == null) return NotFound(); 

        return Ok(pc); 
    }

    [HttpPost]
    public async Task<ActionResult<PCListDto>> Create([FromBody] PCCreateUpdateDto dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState); 

        var createdPc = await _pcService.AddAsync(dto);
        return CreatedAtAction(nameof(GetByIdWithComponents), new { id = createdPc.Id }, createdPc); 
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] PCCreateUpdateDto dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState); 

        var updated = await _pcService.UpdateAsync(id, dto);
        if (!updated) return NotFound(); 

        return Ok(); 
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _pcService.DeleteAsync(id);
        if (!deleted) return NotFound(); 

        return NoContent(); 
    }
}