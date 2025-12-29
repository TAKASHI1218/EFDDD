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
            var o = new DbContextOptionsBuilder<AndersonDBContext>();
            o.UseInMemoryDatabase("MyDataBase");
            o.EnableServiceProviderCaching(false); // キャッシュの無効化
            var context = new AndersonDBContext(o.Options);
            var unitOfWork = new UnitOfWork(context);

            context.Products.Add(new EFDDD.Domain.Entities.ProductEntity(1, "A1", 111));
            context.Products.Add(new EFDDD.Domain.Entities.ProductEntity(2, "A2", 222));
            context.SaveChanges();

            var vm = new Form1ViewModel(unitOfWork);

            Assert.AreEqual(2, vm.Products.Count());
        }
    }
}
