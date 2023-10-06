using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.SchoolDbContext
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> option) : base(option) 
        {
        
        }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public object Subjets { get; internal set; }
    }

}
