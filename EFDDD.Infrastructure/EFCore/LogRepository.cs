using EFDDD.Domain.Entities;
using EFDDD.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Infrastructure.EFCore
{
    internal sealed class LogRepository : Repository<LogEntity>, ILogRepository
    {
        public LogRepository(AndersonDBContext context):base(context)
        {
        }
    }
}
