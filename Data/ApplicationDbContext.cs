using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todo>().HasKey(s=> s.Id);

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.Property(f => f.Id)
                .ValueGeneratedOnAdd();
                entity.Property(p => p.ActivitiesNo)
                .HasComputedColumnSql("'AC-' || substr('0000' || [Id], -4, 4)");
                entity.Property(b => b.CreatedDate)
                .ValueGeneratedOnAdd();
                entity.Property(b => b.UpdatedDate)
                .ValueGeneratedOnUpdate();
            }); 
        }
        
    }
}