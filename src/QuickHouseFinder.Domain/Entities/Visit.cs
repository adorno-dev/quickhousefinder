namespace QuickHouseFinder.Domain.Entities;

public sealed class Visit
{
    public Guid Id { get; set; }
    public Guid AgentId { get; set; }
    public Guid CustomerId { get; set; }
    public Guid PropertyId { get; set; }
    public DateTime VisitDate { get; set; }
    public string? Comment { get; set; }
}