using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TaskItem> TaskItems { get; set; }
        public virtual DbSet<UserItem> UserItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TaskItem>()
                .HasOne(t => t.Assignee)
                .WithMany()
                .HasForeignKey(t => t.AssigneeId)
                .OnDelete(DeleteBehavior.SetNull);


            builder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "Название 1", Description = "Описание 1", CreatedDate = DateTime.Now, FinishedDate = DateTime.Now },
                new TaskItem { Id = 2, Title = "Название 2", Description = "Описание 2", CreatedDate = DateTime.Now, FinishedDate = DateTime.Now },
                new TaskItem { Id = 3, Title = "Название 3", Description = "Описание 3", CreatedDate = DateTime.Now, FinishedDate = DateTime.Now },
                new TaskItem { Id = 4, Title = "Название 4", Description = "Описание 4", CreatedDate = DateTime.Now, FinishedDate = DateTime.Now }
            );


            builder.Entity<UserItem>().HasData(
                new UserItem { Id = 1, FullName = "Пользователь 1", Email = "user1@example.com", RegisteredDate = DateTime.Now },
                new UserItem { Id = 2, FullName = "Пользователь 2", Email = "user2@example.com", RegisteredDate = DateTime.Now }
            );
        }
    }
}
