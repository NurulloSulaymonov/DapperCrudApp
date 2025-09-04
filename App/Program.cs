

using App.entities;
using App.Services;


var companyService = new CompanyService{};
//it does not work with this id, becouse i did a lot insertion
//insert
// companyService.AddCompany("Google");
// companyService.AddCompany("Microsoft");
// companyService.AddCompany("Apple");
// companyService.AddCompany("Amazon");
// companyService.AddCompany("Tesla");
//update
// companyService.Update(new Company { Id = 1, Name = "Google Inc." });
// companyService.Update(new Company { Id = 2, Name = "Microsoft Corp." });
// companyService.Update(new Company { Id = 3, Name = "Apple Inc." });
// companyService.Update(new Company { Id = 4, Name = "Amazon Global" });
// companyService.Update(new Company { Id = 5, Name = "Tesla Motors" });
//delete
// companyService.Delete(1);
// companyService.Delete(2);
// companyService.Delete(3);
// companyService.Delete(4);
// companyService.Delete(5);
List<Company> companies = companyService.GetAll();

Console.WriteLine("All Companies:");
foreach (var company in  companies)
{
    Console.WriteLine($"{company.Id} -- {company.Name}");
}


var branchService = new BranchService { };
//insert
// branchService.AddBranch("New York");
// branchService.AddBranch("London");
// branchService.AddBranch("Berlin");
// branchService.AddBranch("Tokyo");
// branchService.AddBranch("Tashkent");
//update
// branchService.Update(new Branch { Id = 1, Name = "New York HQ" });
// branchService.Update(new Branch { Id = 2, Name = "London Office" });
// branchService.Update(new Branch { Id = 3, Name = "Berlin Center" });
// branchService.Update(new Branch { Id = 4, Name = "Tokyo Hub" });
// branchService.Update(new Branch { Id = 5, Name = "Tashkent Branch" });
//delete
// branchService.Delete(1);
// branchService.Delete(2);
// branchService.Delete(3);
// branchService.Delete(4);
// branchService.Delete(5);
//it does not work with this id, becouse i did a lot insertion
List<Branch> branches = branchService.GetAll();
Console.WriteLine("All Branches:");
foreach (var branch in  branches)
{
    Console.WriteLine($"{branch.Id} -- {branch.Name}");
}


var departmentService = new DepartmentService{ };
List<Department> departments = departmentService.GetAll();
//insert
// departmentService.AddDepartment("Finance");
// departmentService.AddDepartment("HR");
// departmentService.AddDepartment("Engineering");
// departmentService.AddDepartment("Marketing");
// departmentService.AddDepartment("Sales");
//update
// departmentService.Update(new Department { Id = 1, Name = "Finance & Accounting" });
// departmentService.Update(new Department { Id = 2, Name = "Human Resources" });
// departmentService.Update(new Department { Id = 3, Name = "Engineering & Dev" });
// departmentService.Update(new Department { Id = 4, Name = "Marketing Strategy" });
// departmentService.Update(new Department { Id = 5, Name = "Global Sales" });
//delete
// departmentService.Delete(1);
// departmentService.Delete(2);
// departmentService.Delete(3);
// departmentService.Delete(4);
// departmentService.Delete(5);
//it does not work with this id, becouse i did a lot insertion

Console.WriteLine("All Departments:");
foreach (var department in  departments)
{
    Console.WriteLine($"{department.Id} -- {department.Name}");
}



var employeeService = new EmployeeService{ };
List<Employee> employees = employeeService.GetAll();
//insert
// employeeService.AddEmployee("Alice");
// employeeService.AddEmployee("Bob");
// employeeService.AddEmployee("Charlie");
// employeeService.AddEmployee("David");
// employeeService.AddEmployee("Eva");
//update
// employeeService.Update(new Employee { Id = 1, Name = "Alice Johnson" });
// employeeService.Update(new Employee { Id = 2, Name = "Bob Smith" });
// employeeService.Update(new Employee { Id = 3, Name = "Charlie Brown" });
// employeeService.Update(new Employee { Id = 4, Name = "David Miller" });
// employeeService.Update(new Employee { Id = 5, Name = "Eva Davis" });
//delete
// employeeService.Delete(1);
// employeeService.Delete(2);
// employeeService.Delete(3);
// employeeService.Delete(4);
// employeeService.Delete(5);
//it does not work with this id, becouse i did a lot insertion

Console.WriteLine("All Employees:");
foreach (var employee in  employees)
{
    Console.WriteLine($"{employee.Id} -- {employee.Name}");
}






