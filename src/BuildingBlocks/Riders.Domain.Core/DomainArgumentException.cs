namespace Riders.Domain.Core;

public sealed class DomainArgumentException : ArgumentNullException
{
    public DomainArgumentException(string message) : base(message)
    { }
}
