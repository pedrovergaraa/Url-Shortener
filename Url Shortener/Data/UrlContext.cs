using Microsoft.EntityFrameworkCore;
using Url_Shortener.Entities;
using Url_Shortener.Models;

namespace Url_Shortener.Data
{
    public class UrlContext : DbContext
    {
        public UrlContext(DbContextOptions<UrlContext> options) : base(options) 
        { 
        }
        public DbSet<URL> Urls { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }

}
