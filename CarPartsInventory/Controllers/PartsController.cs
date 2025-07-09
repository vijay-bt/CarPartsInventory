using CarPartsInventory.Models;
using CarPartsInventory.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsInventory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PartsController : ControllerBase
{
    private readonly IPartService _service;
    public PartsController(IPartService service) => _service = service;

    [HttpGet("search")]
    public IActionResult Search([FromQuery] string? name) =>
        Ok(_service.Search(name));

    [HttpPost]
    public IActionResult Add([FromBody] Part part) =>
        Ok(_service.Add(part));

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id) =>
        _service.Remove(id) ? Ok("Deleted") : NotFound();
}