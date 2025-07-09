using CarPartsInventory.Models;
using CarPartsInventory.Repositories;

namespace CarPartsInventory.Services;

public class PartService : IPartService
{
    private readonly IPartRepository _repository;

    public PartService(IPartRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Part> GetAll() => _repository.GetAll();

    public IEnumerable<Part> Search(string? name) =>
        _repository.GetAll().Where(p => string.IsNullOrEmpty(name) ||
                                        p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

    public Part Add(Part part) => _repository.Add(part);

    public bool Delete(Guid id) => _repository.Delete(id);

    public bool Update(Guid id, Part updatedPart) => _repository.Update(id, updatedPart);
}