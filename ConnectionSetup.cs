using EFCoreMyTask.Models;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Represents the database context for the EF Core task application.
/// </summary>
namespace EFCoreTask
{
    class ConnectionSetup : DbContext
    {
        /// <summary>
        /// Gets or sets the DbSet representing the Tasks in the database.
        /// </summary>
        public DbSet<MyTask> Tasks { get; set; }

        /// <summary>
        /// Configures the database context with the specified options.
        /// </summary>
        /// <param name="optionsBuilder">The options builder to configure.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            try
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=.;Initial Catalog=EFCoreTask;Integrated Security=True;TrustServerCertificate=True"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while configuring the database context: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Further configures the model that was discovered by convention from the entity types
        /// exposed in Microsoft.EntityFrameworkCore.DbSet`1 properties on your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MyTask>()
                .Property(t => t.Deadline)
                .HasColumnName("Deadline");

            modelBuilder.Entity<MyTask>()
                .Property(t => t.Title)
                .IsRequired();

            modelBuilder.Entity<MyTask>()
                .ToTable("NewTasks");

            modelBuilder.Entity<MyTask>()
                .Property(t => t.Deadline)
                .HasColumnName("Date");
        }
    }
}

