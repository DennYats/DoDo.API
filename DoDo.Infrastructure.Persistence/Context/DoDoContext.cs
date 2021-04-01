using DoDo.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoDo.Infrastructure.Persistence.Context
{
    public class DoDoContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<ToDoSubTask> ToDoSubTasks { get; set; }

        public DoDoContext(DbContextOptions<DoDoContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("_Users");
            builder.Entity<IdentityRole>().ToTable("_Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("_UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("_UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("_UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("_RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("_UserTokens");
        }
    }
}
