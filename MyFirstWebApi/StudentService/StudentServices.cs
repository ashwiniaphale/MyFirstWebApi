using MyFirstWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi.StudentService
{
    public class StudentServices : IStudentService
    {
        public StudentContext _studentDbContext; 

        public StudentServices(StudentContext _studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public Student AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
