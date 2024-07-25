using QuickHouseFinder.Domain.Entities;

namespace QuickHouseFinder.Domain.Repositories;

public interface IPropertyRepository
{
    Task<IEnumerable<Property>?> GetProperties();
    Task<Property?> GetProperty(Guid id);
    Task<Property?> AddProperty(Property property);
    Task UpdateProperty(Property property);
    Task DeleteProperty(Guid id);
}