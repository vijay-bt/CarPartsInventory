using CarPartsInventory.Models;

namespace CarPartsInventory.Services;

public interface IPartService
{
    IEnumerable<Part> Search(string? name);
    Part Add(Part part);
    bool Remove(Guid id);
}