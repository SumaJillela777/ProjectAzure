using System.Diagnostics;
namespace JillelaWeek6.Models
{
    /*created by suma jillela
     * 3333333333333333333333
     * these model classes represent tabes within the database
     * properties in thes eclasses are columns within the table that will be cretaed upon migration
     * data annotations can be added to customize varipus columns settings and constraints
    */
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        //navigation properties
        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}
