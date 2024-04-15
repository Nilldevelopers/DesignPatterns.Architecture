using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace DesignPatterns.Infra.Data.Sql.Queries.Common
{
    public class DbContextDesignPatternsQueryDbContext : BaseQueryDbContext
    {
        public DbContextDesignPatternsQueryDbContext(DbContextOptions<DbContextDesignPatternsQueryDbContext> options) : base(options)
        {
        }
    }
}