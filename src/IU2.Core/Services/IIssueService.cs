using IU2.Core.Models;

namespace IU2.Core.Services;

public interface IIssueService
{
    Task<List<Issue>> GetAllAsync();
    Task<Issue?> GetByIdAsync(int id);
    Task<Issue> CreateAsync(Issue issue);
    Task<List<Issue>> GetByUsernameAsync(string username);
    Task<bool> UpdateStatusAsync(int id, IssueStatus status);
}
