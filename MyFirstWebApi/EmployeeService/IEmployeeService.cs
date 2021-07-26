using MyFirstWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//you must always create an interface for each service class
namespace MyFirstWebApi.EmployeeService
{
    public interface IEmployeeService
    {
        Employee AddEmployee(Employee employee);

       
        public List<Employee> GetEmployees();

        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);

        Employee GetEmployee(int id); 
        

    }
}
