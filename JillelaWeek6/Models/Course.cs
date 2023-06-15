using System.ComponentModel.DataAnnotations.Schema;
namespace JillelaWeek6.Models
{
    //created by suma jillela
    //2222222222222222222222
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
        //navigation property
        public ICollection<Enrollment> ? Enrollments { get; set; }

    }
}
