using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace DesignPatterns.Infra.Data.Sql.Commands.Common
{
    public class DbContextDesignPatternsCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbContextDesignPatternsCommandDbContext(DbContextOptions<DbContextDesignPatternsCommandDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}