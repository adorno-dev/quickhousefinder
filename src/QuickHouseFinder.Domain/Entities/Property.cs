using QuickHouseFinder.Domain.Enums;

namespace QuickHouseFinder.Domain.Entities;

public sealed class Property
{
    public Guid Id { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Description { get; set; }

    public ushort? Bedrooms { get; set; }
    public ushort? Bathrooms { get; set; }
    public ushort? GarageSpaces { get; set; }

    public int Area { get; set; }
    public int SquareMeters { get; set; }

    public decimal? Price { get; set; }
    public ContractType ContractType { get; set; }

    // 

    public Guid OwnerId { get; set; }
    public Customer? Owner { get; set; }
}