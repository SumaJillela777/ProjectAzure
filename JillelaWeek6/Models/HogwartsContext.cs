using Microsoft.EntityFrameworkCore;

namespace JillelaWeek6.Models
{
    public class HogwartsContext : DbContext
    {
        //created by suma jillela
        //44444444444444444444444
        //DBContext class is a derived class from the parent clas called DbCntext
        //include the base type;DbContext next to the class name
        public HogwartsContext(DbContextOptions<HogwartsContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
