using HotChocolate;
using HotChocolate.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolsService.Model      
{
    [GraphQLDescription("School entity")]
    public class School
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchooldId { get; set; }

        public string SchoolName { get; set; }

        [UseSorting]    
        [UseFiltering]
        [GraphQLDescription("List of school's students")]
        public ICollection<Student> Students { get; set; }
    }
}
