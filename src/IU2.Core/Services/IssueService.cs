using IU2.Core.Data;
using IU2.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace IU2.Core.Services;

public class IssueService : IIssueService
{
    private readonly IDbContextFactory<AppDbContext> _factory;

    public IssueService(IDbContextFactory<AppDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<Issue>> GetAllAsync()
    {
        await using var db = await _factory.CreateDbContextAsync();
        return await db.Issues
            .AsNoTracking()
            .OrderByDescending(i => i.CreatedAt)
            .ToListAsync();
    }

    public async Task<Issue?> GetByIdAsync(int id)
    {
        await using var db = await _factory.CreateDbContextAsync();
        return await db.Issues.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
    }

    public async Task<Issue> CreateAsync(Issue issue)
    {
        await using var db = await _factory.CreateDbContextAsync();
        issue.CreatedAt = DateTime.UtcNow;
        issue.Status = IssueStatus.New;
        db.Issues.Add(issue);
        await db.SaveChangesAsync();
        return issue;
    }

    public async Task<bool> UpdateStatusAsync(int id, IssueStatus status)
    {
        await using var db = await _factory.CreateDbContextAsync();
        var issue = await db.Issues.FindAsync(id);
        if (issue is null) return false;

        issue.Status = status;
        await db.SaveChangesAsync();
        return true;
    }
}
