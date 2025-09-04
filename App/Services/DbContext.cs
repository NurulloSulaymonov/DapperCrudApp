using System.Data;
using Npgsql;

namespace App.Services;

public class DbContext
{
    private readonly string _connectionString;

    public DbContext()
    {
        _connectionString = "Host=localhost;Port=5432;Database=appcompany_db;Username=postgres;Password=321654muha;"; //

    }

    public IDbConnection CreateConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }
}