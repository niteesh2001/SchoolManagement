using SchoolManagement.Models;
using System.Data.Entity;


public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=SchoolDbContext")
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Class> Classes { get; set; }

 
}
