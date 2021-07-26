using MyFirstWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi.EmployeeService
{
    public class EmployeeServices : IEmployeeService
    {
        public EmployeeContext _employeeDbContext; 

        public EmployeeServices(EmployeeContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Add(employee);
            _employeeDbContext.SaveChanges();
            return employee; 
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employeeDbContext.Employees.FirstOrDefault(x => x.ID == id); 
            if(employee != null)
            {
                _employeeDbContext.Employees.Remove(employee);
                _employeeDbContext.SaveChanges(); 
            }
        }

        public Employee GetEmployee(int id)
        {
            return _employeeDbContext.Employees.FirstOrDefault(x => x.ID == id); 
        }

        public List<Employee> GetEmployees()
        {
            return _employeeDbContext.Employees.ToList<Employee>(); 
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Update(employee);
            _employeeDbContext.SaveChanges(); 

        }

        
    }
}
