using Microsoft.EntityFrameworkCore;
using Model;

namespace MaWebAPI.Contexts
{
    public class ArticleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=bd_articles.db");
        }

        public DbSet<Article> ArticleItems { get; set; }
    }
}
