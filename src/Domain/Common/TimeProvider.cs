namespace Domain.Common;

public interface ITimeProvider
{
    DateTime Now { get; }
    DateTime UtcNow { get; }
}

public class TimeProvider : ITimeProvider
{
    public DateTime Now => DateTime.Now;
    public DateTime UtcNow => DateTime.UtcNow;
}