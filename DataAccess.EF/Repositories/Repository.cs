using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EF.Repositories
{
    public abstract class Repository
    {
        public EfDbContext Context { get; }

        public Repository(EfDbContext context)
        {
            this.Context = context;
        }

    }
}
