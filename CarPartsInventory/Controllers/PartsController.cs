using CarPartsInventory.Models;
using CarPartsInventory.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsInventory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PartsController : ControllerBase
{
    private readonly IPartService _service;

    public PartsController(IPartService service)
    {
        _service = service;
    }

    [HttpGet("search")]
    public IActionResult Search([FromQuery] string? name) =>
        Ok(_service.Search(name));

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpPost]
    public IActionResult Add([FromBody] Part part)
    {
        var added = _service.Add(part);
        return CreatedAtAction(nameof(GetAll), new { id = added.Id }, added);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        if (_service.Delete(id))
            return NoContent();
        return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] Part updatedPart)
    {
        if (_service.Update(id, updatedPart))
            return NoContent();
        return NotFound();
    }
}