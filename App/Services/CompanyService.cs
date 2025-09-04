using App.entities;
using Dapper;

namespace App.Services;

public class CompanyService
{
    private readonly DbContext _db;

    public CompanyService()
    {
        _db = new DbContext();
    }

    public void AddCompany(string name)
    {
        using var conn = _db.CreateConnection();
        string sql = "INSERT INTO Companies (Name) VALUES (@Name)";
        conn.Execute(sql, new { Name = name });
    }

    public List<Company> GetAll()
    {
        using var conn = _db.CreateConnection();
        return conn.Query<Company>("SELECT * FROM companies").ToList();
    }
    
    public int Update(Company company)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "update companies set name = @Name where company_id=@id";
            var response = conn.Execute(sql, company);
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }
    
    public int Delete(int id)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "delete from companies where company_id=@id";
            var response = conn.Execute(sql,new {id});
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }
}