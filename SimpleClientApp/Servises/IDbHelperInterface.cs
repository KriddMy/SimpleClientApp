using SimpleClientApp.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClientApp.Servises
{
    public interface IDbHelperInterface
    {
        DbSet<Sells>        SellsDbSet { get; }
        DbSet<Customers>    CustomersDbSet { get; }
        DbSet<Goods>        GoodsDbSet { get; }

        void SaveChanges();
    }
}
