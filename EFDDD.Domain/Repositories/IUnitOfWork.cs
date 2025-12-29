using System; 
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.Repositories
{
    public interface IUnitOfWork
    {
        
        IProductRepository ProductRepository { get; }
        ILogRepository LogRepository { get; }
        void ExeBegin();
        void ExeCommit();
        void ExeSave();
        void Dispose();
    }
}
