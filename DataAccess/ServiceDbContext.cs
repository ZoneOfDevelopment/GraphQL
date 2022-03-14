using Microsoft.EntityFrameworkCore;
using SchoolsService.Model;

namespace SchoolsService.DataAccess
{
    public class ServiceDbContext:DbContext
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
        {
        }

        public DbSet<School> Schools => Set<School>();
        public DbSet<Student> Students => Set<Student>();
    }
}
