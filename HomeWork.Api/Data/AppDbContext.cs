using HomeWork.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.Api.Data;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public DbSet<TaskEntity>? Tasks { get; set; } 
    public DbSet<UserTask>? UserTasks { get; set; } 
    public DbSet<Course>? Courses { get; set; } 
    public DbSet<UserCourse>? UserCourses { get; set; } 
    public DbSet<TaskComment>? TaskComments { get; set; } 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
