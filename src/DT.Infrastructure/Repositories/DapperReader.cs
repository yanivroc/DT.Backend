using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using DT.Application.Interfaces;

namespace DT.Infrastructure.Repositories;

public class DapperReader : IDapperReader
{
    private readonly string _cs;
    public DapperReader(IConfiguration cfg)
    {
        _cs = cfg.GetConnectionString("Default")
            ?? throw new InvalidOperationException("ConnectionStrings:Default missing");
    }

    private IDbConnection Conn() => new MySqlConnection(_cs);

    public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null)
    {
        using var c = Conn();
        return await c.QueryAsync<T>(sql, param);
    }

    public async Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? param = null)
    {
        using var c = Conn();
        return await c.QueryFirstOrDefaultAsync<T>(sql, param);
    }
}
