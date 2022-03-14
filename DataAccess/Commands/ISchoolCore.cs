using SchoolsService.Model;
using System.Linq;

namespace SchoolsService.DataAccess.Commands
{
    public interface ISchoolCore
    {
        IQueryable<School> GetAllSchools();
        School AddSchool(School school);

    }
}
