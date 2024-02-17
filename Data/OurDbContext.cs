using Microsoft.EntityFrameworkCore;
using MyTask.Models;
using Task = MyTask.Models.Task;
namespace MyTask.Data
{
    public class OurDbContext : DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    //    public override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    modelBuilder.Entity<User>()
    //        .HasMany(u => u.Tasks)
    //        .WithOne(t => t.User)
    //        .HasForeignKey(t => t.UserId);
    //}
        public OurDbContext(DbContextOptions options) : base(options) { }

        //public static OurDbContext Create()
        //{
        //    return new OurDbContext();
        //}
        
    }
}
