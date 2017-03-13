using Microsoft.EntityFrameworkCore;

namespace Hackathon.Web.Data
{

    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options)
            : base(options)
        { }

        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }
    }
}