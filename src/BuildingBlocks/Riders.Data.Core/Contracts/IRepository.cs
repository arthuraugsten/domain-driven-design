namespace Riders.Data.Core.Contracts;

public interface IRepository
{
    IUnitOfWork UnitOfWork { get; }
}
