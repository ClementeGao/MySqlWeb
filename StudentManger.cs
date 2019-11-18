using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql.Web
{
    public class StudentManger : IStudentManger
    {
        private readonly SchoolDbContext _schoolDbContext;


        public StudentManger(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public string CreateStudent()
        {
            var student = new Student()
            {
                Age = 12,
                Height = 173,
                IsTest = false,
                Name = "高晟"
            };
            var entity = _schoolDbContext.Students.Add(student);

            if (_schoolDbContext.SaveChanges() > 0)
            {
                return student.Name;
            }

            return "";
        }

        public bool DeleteStudentById(int Id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            var student = _schoolDbContext.Students.FirstOrDefault(s => s.Id == id);

            return student;
        }

        public bool UpdateStudent(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
