using FileTypeExample.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FileTypeExample.Infrastructure.Context
{
    public class FileTypeExampleDbContext : DbContext
    {
        public FileTypeExampleDbContext(DbContextOptions<FileTypeExampleDbContext> options) : base(options)
        {
        }

        public DbSet<News> News{ get; set; }
        public DbSet<BigPara> BigPara { get; set; }
        public DbSet<Adv> Advertorial { get; set; }
    }
}
