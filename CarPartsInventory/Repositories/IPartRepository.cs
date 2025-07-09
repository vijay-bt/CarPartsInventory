using CarPartsInventory.Models;

namespace CarPartsInventory.Repositories;

public interface IPartRepository
{
    IEnumerable<Part> GetAll();
    Part Add(Part part);
    bool Delete(Guid id);
    bool Update(Guid id, Part updatedPart); // Add this line
}