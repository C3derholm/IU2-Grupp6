using IU2.Core;
using Xunit;

namespace IU2.Core.Tests;

public class SmokeTests
{
    [Fact]
    public void FakeClock_returnerar_den_tid_den_fick()
    {
        var tid = new DateTimeOffset(2026, 9, 30, 9, 0, 0, TimeSpan.FromHours(2));

        IClock klocka = new FakeClock(tid);

        Assert.Equal(tid, klocka.Now);
    }

    [Fact]
    public void SystemClock_gar_framat()
    {
        IClock klocka = new SystemClock();

        Assert.True(klocka.Now > new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero));
    }
}
