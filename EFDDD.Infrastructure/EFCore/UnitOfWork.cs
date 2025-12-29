using EFDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Infrastructure.EFCore
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private AndersonDBContext _context;

        public UnitOfWork(AndersonDBContext context)
        {
            _context = context;
        }

        private IProductRepository _productRepository;
        public IProductRepository ProductRepository 
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_context);

                }
                return _productRepository;
            }
        }

        private ILogRepository _logRepository;

        public ILogRepository LogRepository
        {
            get
            {
                if (_logRepository == null)
                {
                    _logRepository = new LogRepository(_context);
                }
                return _logRepository;
            }
        }

        public void ExeBegin()
        {
            _context.Database.BeginTransaction();
        }

        public void ExeCommit()
        {
            _context.Database.CommitTransaction();
        }

        public void ExeSave()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
