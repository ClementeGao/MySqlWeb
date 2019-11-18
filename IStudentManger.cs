using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql.Web
{
    public interface IStudentManger
    {
        string CreateStudent();

        Student GetStudentById(int id);

        bool UpdateStudent(int Id);

        bool DeleteStudentById(int Id);
    }
}
