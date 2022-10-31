using SimpleClientApp.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClientApp.Servises
{
    internal class DbHelper : IDbHelperInterface
    {
        private DataModelContainer DbContext { get; set; }

        public virtual DbSet<Customers> CustomersDbSet  => DbContext.CustomersSet;
        public virtual DbSet<Sells>     SellsDbSet      => DbContext.SellsSet;
        public virtual DbSet<Goods>     GoodsDbSet      => DbContext.GoodsSet;

        public DbHelper()
        {
            DbContext = new DataModelContainer();

            //CustomersDbSet.RemoveRange(CustomersDbSet);
            //SellsDbSet.RemoveRange(SellsDbSet);
            //GoodsDbSet.RemoveRange(GoodsDbSet);
            //DbContext.SaveChanges();

            CustomersDbSet.Load();
            SellsDbSet.Load();
            GoodsDbSet.Load();

        }

        public virtual void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
