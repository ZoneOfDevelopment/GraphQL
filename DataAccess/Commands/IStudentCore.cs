using SchoolsService.Model;
using System.Linq;

namespace SchoolsService.DataAccess.Commands
{
    public interface IStudentCore
    {
        IQueryable<Student> GetAllStudents();
        Student AddStudent(Student student);
    }
}
