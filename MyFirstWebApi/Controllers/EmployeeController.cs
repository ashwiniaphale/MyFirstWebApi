using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.EmployeeService;
using MyFirstWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> emp;
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            //fill up constructor with emp
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        
        public List<Employee> Get() //retrieve all employees
        {
            return employeeService.GetEmployees();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee GetOne(int id) //one single employee with that ID
        
        {
            foreach(var e in emp)
            {
                if(e.ID == id)
                {
                    return e; 
                }
            }
            return new Employee(); //if no ID is found
        }
        
       // [HttpGet("{dept}")]
        [HttpGet("GetByDept/{dept}")]
        public List<Employee> Get(string dept)
        {
            //used 
            var deptList = from i in emp
                           where i.department.Equals(dept.ToUpper())
                           select i;

            return deptList.ToList(); //converts straight to list
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public Employee Post([FromBody] Employee value) //create new employee 
        {
            employeeService.AddEmployee(value);
            return value; 
            
        }

        // PUT api/<EmployeeController>/5
        /*
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        */

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public List<Employee> Delete(int id) //delete using ID and return all objects
        {
            //var a = emp.Where(x => x.ID == id).FirstOrDefault();
            var a = from i in emp
                    where i.ID.Equals(id)
                    select i; 
            emp.Remove(a.FirstOrDefault()); 
            return emp; 
        }
    }
}
