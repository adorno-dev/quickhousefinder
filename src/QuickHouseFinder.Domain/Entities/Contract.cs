using QuickHouseFinder.Domain.Enums;

namespace QuickHouseFinder.Domain.Entities;

public class Contract
{
    public Guid Id { get; set; }
    public Guid PropertyId { get; set; }
    public Guid CustomerId { get; set; }
    public Guid AgentId { get; set; }
    public ContractType ContractType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal TotalAmount { get; set; }
    public ContractStatus Status { get; set; }
}