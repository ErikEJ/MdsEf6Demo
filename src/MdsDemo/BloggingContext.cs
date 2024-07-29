using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace MdsDemo
{
    [DbConfigurationType(typeof(MicrosoftSqlDbConfiguration))]
    public partial class BloggingContext : DbContext
    {
        public BloggingContext()
            : base("name=BloggingContext")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
