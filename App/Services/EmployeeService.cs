using App.entities;
using Dapper;

namespace App.Services;

public class EmployeeService
{
    private readonly DbContext _db;

    public EmployeeService()
    {
        _db = new DbContext();
    }

    public void AddEmployee(string name)
    {
        using var conn = _db.CreateConnection();
        string sql = "INSERT INTO Employees (full_name) VALUES (@Name)";
        conn.Execute(sql, new { Name = name });
    }

    public List<Employee> GetAll()
    {
        using var conn = _db.CreateConnection();
        return conn.Query<Employee>("SELECT * FROM Employees").ToList();
    }
    
    public int Update(Employee employee)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "update employees set name = @Name where employee_id=@id";
            var response = conn.Execute(sql, employee);
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }
    
    public int Delete(int id)
    {
        using (var conn = _db.CreateConnection())
        {
            conn.Open();
            string sql = "delete from employees where employee_id=@id";
            var response = conn.Execute(sql,new {id});
            if (response == 0) throw new Exception("There was some error");
            return response;
        }
    }

}