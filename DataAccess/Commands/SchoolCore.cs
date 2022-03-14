using Microsoft.EntityFrameworkCore;
using SchoolsService.Model;
using System.Linq;

namespace SchoolsService.DataAccess.Commands
{
    public class SchoolCore : ISchoolCore
    {
        private readonly ServiceDbContext _dbContext;

        public SchoolCore(ServiceDbContext dbContext)
        {
            _dbContext = dbContext;
            FeedDbInMemory();
        }
        public School AddSchool(School school)
        {
            _dbContext.Schools.Add(school);
            _dbContext.SaveChanges();
            return school;
        }

        public IQueryable<School> GetAllSchools()
        {
            return _dbContext.Schools.Include(i => i.Students);
        }

        private void FeedDbInMemory()
        {
            if (!_dbContext.Schools.Any())
            {
                var school1 = new School { SchooldId = 1, SchoolName = "School_1"};
                var school2 = new School { SchooldId = 2, SchoolName = "School_2" };
                _dbContext.Schools.Add(school1);
                _dbContext.Schools.Add(school2);
                _dbContext.SaveChanges();
            }
        }
    }
}
