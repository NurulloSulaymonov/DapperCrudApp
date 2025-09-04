using App.entities;
using Dapper;

namespace App.Services;

public class BranchService
{
    private readonly DbContext _db;
    
    public BranchService()
    {
        _db = new DbContext();
    }
    
    public void AddBranch(string name)
    {
        using var conn = _db.CreateConnection();
        string sql = "INSERT INTO Branches (Name) VALUES (@Name)";
        conn.Execute(sql, new { Name = name });
    }
    
    public List<Branch> GetAll()
    {
        using var conn = _db.CreateConnection();
        return conn.Query<Branch>("SELECT * FROM Branches").ToList();
    }
    
    public int Update(Branch branch)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "update branches set name = @Name where branch_id=@id";
            var response = conn.Execute(sql, branch);
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }
    
    public int Delete(int id)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "delete from branches where branch_id=@id";
            var response = conn.Execute(sql,new {id});
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }
}