namespace IU2.Core.Models;

public static class IssueStatusExtensions
{
    public static string TillSvenska(this IssueStatus status) => status switch
    {
        IssueStatus.New => "Nytt",
        IssueStatus.InProgress => "Pågående",
        IssueStatus.Done => "Löst",
        _ => status.ToString()
    };
}
