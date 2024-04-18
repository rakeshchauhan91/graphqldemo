using GraphQL.Application.Interfaces;
using GraphQL.Domain.Entities;
using GraphQL.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace GraphQL.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("sqlConString"));

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid() };
            modelBuilder.ApplyConfiguration(new OwnerContextConfiguration(ids));
            modelBuilder.ApplyConfiguration(new AccountContextConfiguration(ids));
        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
