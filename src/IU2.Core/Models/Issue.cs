using System.ComponentModel.DataAnnotations;

namespace IU2.Core.Models;

public enum IssueStatus { New, InProgress, Done }

public enum IssuePriority { Low, Medium, High }

public class Issue
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required, MaxLength(2000)]
    public string Description { get; set; } = string.Empty;

    public IssueStatus Status { get; set; } = IssueStatus.New;

    public IssuePriority Priority { get; set; } = IssuePriority.Medium;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
