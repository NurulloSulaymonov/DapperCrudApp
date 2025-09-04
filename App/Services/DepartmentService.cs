using App.entities;
using Dapper;

namespace App.Services;

public class DepartmentService
{
    private readonly DbContext _db;

    public DepartmentService()
    {
        _db = new DbContext();
    }

    public void AddDepartment(string name)
    {
        using var conn = _db.CreateConnection();
        string sql = "INSERT INTO Departments (Name) VALUES (@Name)";
        conn.Execute(sql, new { Name = name });
    }

    public List<Department> GetAll()
    {
        using var conn = _db.CreateConnection();
        return conn.Query<Department>("SELECT * FROM Departments").ToList();
    }
    
    public int Update(Department department)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "update departments set name = @Name where department_id=@id";
            var response = conn.Execute(sql, department);
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }
    
    public int Delete(int id)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "delete from departments where department_id=@id";
            var response = conn.Execute(sql,new {id});
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }
}