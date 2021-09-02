using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using FileTypeExample.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(FileTypeExampleDbContext context) : base(context)
        {
        }

        public IEnumerable<News> GetNewsSPAsc()
        {
            return _context.News.FromSqlInterpolated($"EXEC dbo.NewsAsc").ToListAsync().Result;
        }

        public IEnumerable<News> GetNewsSPDesc()
        {
            return _context.News.FromSqlInterpolated($"EXEC dbo.NewsDesc").ToListAsync().Result;
        }

        public IEnumerable<News> GetNewsOrderAsc()
        {
            return _context.News.OrderBy(x => x.Title.Length).ToList();
        }

        public IEnumerable<News> GetNewsOrderDesc()
        {
            return _context.News.OrderByDescending(x => x.Title.Length).ToList();
        }

        public IEnumerable<News> GetNewsWithSearch(string search)
        {
            return _context.News.Where(x => x.Title.Contains(search) || x.Text.Contains(search)).ToList();
        }
    }
}
