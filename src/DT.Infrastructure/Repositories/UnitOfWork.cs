using DT.Application.Interfaces;
using DT.Infrastructure.Persistence;

namespace DT.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _ctx;
    private readonly Dictionary<Type, object> _repos = new();

    public UnitOfWork(AppDbContext ctx) { _ctx = ctx; }

    public IGenericRepository<T> Repository<T>() where T : class
    {
        if (!_repos.TryGetValue(typeof(T), out var repo))
        {
            repo = new GenericRepository<T>(_ctx);
            _repos[typeof(T)] = repo;
        }
        return (IGenericRepository<T>)repo;
    }

    public Task<int> CommitAsync(CancellationToken ct = default) => _ctx.SaveChangesAsync(ct);
    public void Dispose() => _ctx.Dispose();
}
