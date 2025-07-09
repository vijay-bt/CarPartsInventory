using CarPartsInventory.Models;

namespace CarPartsInventory.Services;

public interface IPartService
{
    IEnumerable<Part> GetAll();
    Part Add(Part part);
    bool Delete(Guid id);
    bool Update(Guid id, Part updatedPart);
    IEnumerable<Part> Search(string? name); // Added the missing Search method
}