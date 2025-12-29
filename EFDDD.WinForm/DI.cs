using EFDDD.Domain.Repositories;
using EFDDD.Infrastructure.EFCore;
using EFDDD.WinForm.VeiwModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFDDD.WinForm
{
    internal static class DI
    {
        private static ServiceCollection _services = new();
        private static ServiceProvider _serviceProvider;

        static DI()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\MSSQLLocalDB";
            builder.InitialCatalog = "AndersonD";
            builder.IntegratedSecurity = true;
            //var o = new DbContextOptionsBuilder<AndersonDBContext>();
            //o.UseSqlServer(builder.ConnectionString);

            _services.AddDbContext<AndersonDBContext>(o => o.UseSqlServer(builder.ConnectionString));
            _services.AddTransient<IUnitOfWork, UnitOfWork>();
            _services.AddTransient<Form1ViewModel>();
            _serviceProvider = _services.BuildServiceProvider();
        }

        internal static T Resolve<T>() where T : notnull
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
