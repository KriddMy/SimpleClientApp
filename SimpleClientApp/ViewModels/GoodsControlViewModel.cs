using DevExpress.Data;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraGrid.Views.Base;
using SimpleClientApp.Servises;
using System;
namespace SimpleClientApp.ViewModels
{
    [POCOViewModel]
    public class GoodsControlViewModel
    {
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