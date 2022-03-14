using HotChocolate;
using HotChocolate.Data;
using SchoolsService.DataAccess.Commands;
using SchoolsService.Model;
using System.Linq;

namespace SchoolsService.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Students")]
        public IQueryable<Student> AllStudents([Service] IStudentCore studentCore)
        {
            return studentCore.GetAllStudents();
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<School> AllSchool([Service] ISchoolCore schoolCore)
        {
            return schoolCore.GetAllSchools();
        }
    }
}
