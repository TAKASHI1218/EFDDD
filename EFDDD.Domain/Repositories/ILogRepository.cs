using EFDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.Repositories
{
    public interface ILogRepository
    {
        IEnumerable<LogEntity> GetAll();
        void Add(LogEntity entity);
    }
}
