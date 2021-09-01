using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using FileTypeExample.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(FileTypeExampleDbContext context) : base(context)
        {
        }

        public IEnumerable<News> GetAdvOrderAsc()
        {
            return _context.News.OrderBy(x => x.Title.Length).ToList();
        }

        public IEnumerable<News> GetAdvOrderDesc()
        {
            return _context.News.OrderByDescending(x => x.Title.Length).ToList();
        }

        public IEnumerable<News> GetNewsWithSearch(string search)
        {
            return _context.News.Where(x => x.Title.Contains(search) || x.Text.Contains(search)).ToList();
        }
    }
}
