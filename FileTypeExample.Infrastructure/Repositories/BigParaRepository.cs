﻿using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using FileTypeExample.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class BigParaRepository : Repository<BigPara>, IBigParaRepository
    {
        public BigParaRepository(FileTypeExampleDbContext context) : base(context)
        {
        }

        public IEnumerable<BigPara> GetBigParaWithSearchAsync(string search)
        {
            return _context.BigPara.Where(x => x.Title.Contains(search) || x.Spot.Contains(search)).ToList();
        }
    }
}
