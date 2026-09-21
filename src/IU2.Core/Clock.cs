namespace IU2.Core;

/// <summary>
/// Ett litet exempel på en söm: koden frågar efter tiden i stället för att
/// hämta den själv, så att testerna kan bestämma vad klockan är.
/// Behåll mönstret, kasta gärna klassen när ni har en egen domän.
/// </summary>
public interface IClock
{
    DateTimeOffset Now { get; }
}

public sealed class SystemClock : IClock
{
    public DateTimeOffset Now => DateTimeOffset.Now;
}

public sealed class FakeClock(DateTimeOffset fixedTime) : IClock
{
    public DateTimeOffset Now { get; } = fixedTime;
}
