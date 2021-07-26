using MyFirstWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi.StudentService
{
    public interface IStudentService
    {
        Student AddStudent(Student student);

        public List<Student> GetStudents();

        void UpdateStudent(Student student);
        void DeleteStudent(int id);

        Student GetStudent(int id);
    }
}
