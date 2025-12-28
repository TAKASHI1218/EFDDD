using EFDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Infrastructure.EFCore
{
    internal abstract class Repository<T> where T:class
    {
        protected AndersonDBContext _context;

        public Repository(AndersonDBContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

    }
}
