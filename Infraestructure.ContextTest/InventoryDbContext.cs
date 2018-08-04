using Infraestructure.Context.Inventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infraestructure.ContextTest
{
    [TestClass]
    public class InventoryDbContext
    {
        [AssemblyInitialize]
        public static void EnviromentSetup(TestContext testContext)
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Database.EnsureDeleted();
            }
        }

        [TestMethod]
        public void CreateDatabase()
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
