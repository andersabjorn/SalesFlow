using SalesFlow.Core.Enums;

namespace SalesFlow.Core.Entities;

public class Lead
{ 
public int Id { get; set; }
public string Name { get; set; } = string.Empty;
public string Company { get; set; } = string.Empty;
public string Email { get; set; } = string.Empty;
public string Phone { get; set; } = string.Empty;
public string Website { get; set; } = string.Empty;

public LeadStatus Status { get; set; }
public decimal EstimatedValue { get; set; }
public DateTime CreatedDate { get; set; }
public DateTime? LastContactedDate { get; set; }
public DateTime? NextFollowUpDate { get; set; }
public string Notes { get; set; } = string.Empty;

}
