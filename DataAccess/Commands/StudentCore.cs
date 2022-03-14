using SchoolsService.Model;
using System.Linq;

namespace SchoolsService.DataAccess.Commands
{
    public class StudentCore : IStudentCore
    {
        private readonly ServiceDbContext _dbContext;

        public StudentCore(ServiceDbContext dbContext)
        {
            _dbContext = dbContext;
            FeedDbInMemory();
        }

        public Student AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return student;
        }

        public IQueryable<Student> GetAllStudents()
        {
            return _dbContext.Students.AsQueryable();
        }

        private void FeedDbInMemory()
        {
            if (!_dbContext.Students.Any())
            {
                for (int i = 1; i < 10; i++)
                {
                    var student = new Student { Age = i % 2 == 0 ? 16 : 15, Email = $"email{i}@test.com", Name = $"NameStudent{i}", Surname = $"SernameStudent{i}", SchoolID = i % 2 == 0 ? 1 : 2 };
                    _dbContext.Students.Add(student);
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
