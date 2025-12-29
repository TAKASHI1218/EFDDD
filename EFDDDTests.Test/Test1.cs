using EFDDD.Infrastructure.EFCore;
using EFDDD.WinForm.VeiwModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EFDDDTests.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\MSSQLLocalDB";
            builder.InitialCatalog = "AndersonD";
            builder.IntegratedSecurity = true;
            var o = new DbContextOptionsBuilder<AndersonDBContext>();
            o.UseSqlServer(builder.ConnectionString);


            var context = new AndersonDBContext();
            var unitOfWork = new UnitOfWork(context);
            var vm = new Form1ViewModel(unitOfWork);

        }
    }
}
