namespace JillelaWeek6.Models
    /*created by Suma Jillela
     * 1111111111111111111111
     * these are the model classes represent tables within the database
     * the properties in these classes are columns within the table that will be created upon migration
     * data annotations can be added to customize varipus columns settings and constraints
     */
{
    public class Student
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        public DateTime EntrollmentDate { get; set; }
        //Navigation property
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
