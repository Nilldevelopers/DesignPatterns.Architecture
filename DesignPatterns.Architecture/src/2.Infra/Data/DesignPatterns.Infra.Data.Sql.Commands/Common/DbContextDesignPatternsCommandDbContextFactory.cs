using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DesignPatterns.Infra.Data.Sql.Commands.Common
{
    public class DbContextDesignPatternsCommandDbContextFactory : IDesignTimeDbContextFactory<DbContextDesignPatternsCommandDbContext>
    {
        public DbContextDesignPatternsCommandDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DbContextDesignPatternsCommandDbContext>();

            builder.UseSqlServer("Server =.; Database=DbContextDesignPatternsDb;User Id = ;Password = ; MultipleActiveResultSets = true; Encrypt = false");

            return new DbContextDesignPatternsCommandDbContext(builder.Options);
        }
    }
}