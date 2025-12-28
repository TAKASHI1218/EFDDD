using EFDDD.Domain.Repositories;
using EFDDD.Infrastructure.EFCore;

namespace EFDDD.Infrastructure
{
    public static class Factories
    {
        public static IProductRepository CreateProduct(AndersonDBContext? context)
        {
            return new ProductRepository(context!);
        }

        public static ILogRepository CreateLog(AndersonDBContext? context)
        {
            return new LogRepository(context!);
        }
    }
}
