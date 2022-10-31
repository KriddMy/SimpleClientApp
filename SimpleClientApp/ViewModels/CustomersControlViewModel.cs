using DevExpress.Data;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraGrid.Views.Base;
using SimpleClientApp.DataModels;
using SimpleClientApp.Servises;
using System;
using System.Collections.Specialized;
using System.Linq;

namespace SimpleClientApp.ViewModels
{
    [POCOViewModel]
    public class CustomersControlViewModel
    {
        public virtual bool ReloadCustomerDataTriggerFlag { get; set; }

        public CustomersControlViewModel()
        {
            DbHelper.CustomersDbSet.Local.CollectionChanged += Customers_CollectionChanged;
            DbHelper.SellsDbSet.Local.CollectionChanged += Sells_CollectionChanged;
        }

        private void Sells_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ReloadCustomerDataTriggerFlag = !ReloadCustomerDataTriggerFlag;
        }

        private void Customers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach(Customers customerElement in e.OldItems)
                {
                    var sellsToDelete = DbHelper.SellsDbSet.Local.Where(
                        (sellElement) => customerElement.Id == sellElement.CustomersID)
                        .ToList();

                    sellsToDelete.ForEach((sellsElement) => DbHelper.SellsDbSet.Local.Remove(sellsElement));
                }
            }
        }

        [ServiceProperty]
        public virtual IDbHelperInterface DbHelper
        {
            get { throw new System.NotImplementedException(); }
        }

        public void TableUpdated(RowObjectEventArgs e)
        {
            DbHelper.SaveChanges();
        }

        public void TableDeleted(RowDeletedEventArgs e)
        {
            DbHelper.SaveChanges();
        }
    }
}