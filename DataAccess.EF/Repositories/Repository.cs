using DataAccess.EF.DbContextImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EF.Repositories
{
    public abstract class Repository(EfDbContext context)
    {
        public EfDbContext Context { get; } = context;
    }
}
